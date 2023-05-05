using LakesSurvey;
using LakesSurveyModels.Models;

var apiClient = new DnrApiClient();
var dataMapper = new DnrLakesDataMapper();

await dataMapper.LoadFishTypes();

await dataMapper.LoadLakes();

var lakeList = dataMapper.GetLakes();

foreach (var lakeId in lakeList)
{
     Console.WriteLine($"Getting survey for {lakeId.LakeId} ({lakeId.LakeName}), {lakeId.County} County...");
     try
     {
         var surveyResult = await apiClient.GetSurveyResponse(lakeId.LakeId);
         if (surveyResult.Status != "SUCCESS" && !(lakeId.Survey > 0))
         {
             await dataMapper.UpdateLakeList(lakeId, -1);
             continue;
         }

         var surveyId = await dataMapper.LoadSurveyResult(surveyResult, lakeId);
         
         if (surveyId > 0)
         {
             await dataMapper.UpdateLakeList(lakeId, surveyId);
         }
     }
     catch
     {
         await dataMapper.UpdateLakeList(lakeId, -2);
         Console.WriteLine($"Unable to get data for {lakeId.LakeId} ({lakeId.LakeName})");
     }
}


// var badCoordinatesLakes = lakeList.Where(l => l.Distance > 1000 && l.Survey > 0);

// foreach (var lake in badCoordinatesLakes)
// {
//     var latitude = Double.Parse(lake.Coordinates.Split(", ")[1]);
//     var longitude = Double.Parse(lake.Coordinates.Split(", ")[0]);
//     var fixedDistance = apiClient.GetDistance(longitude, latitude);
//
//     if (Math.Abs(lake.Distance - fixedDistance) > .001)
//     {
//         lake.Distance = fixedDistance;
//         Console.WriteLine($"{lake.LakeName} - {fixedDistance}");
//         await dataMapper.UpdateLakeList(lake, lake.Survey);
//     }
// }
