namespace LakesSurvey;

public class SurveyProcessor
{
    private DnrApiClient _apiClient;
    private DateTime startDate;
    private DateTime endDate;
    
    public SurveyProcessor()
    {
        _apiClient = new DnrApiClient();
    }

    public async Task ProcessLakesParallel() // 00:02:43.1176670
    {
        startDate = DateTime.Now;

        var dataMapper = new DnrLakesDataMapper();
        await dataMapper.LoadFishTypes();

        await dataMapper.LoadLakes();

        var lakeList = dataMapper.GetLakes();
        
        var options = new ParallelOptions()
        {
            MaxDegreeOfParallelism = 20
        };

        await Parallel.ForEachAsync(lakeList, options , async (lakeId, ct) =>
        {
            var tDataMapper = new DnrLakesDataMapper();
            Console.WriteLine($"Getting surveys for {lakeId.LakeId} ({lakeId.LakeName}), {lakeId.County} County...");
            try
            {
                var surveyResult = await _apiClient.GetSurveyResponse(lakeId.LakeId);
                if (surveyResult.Status != "SUCCESS" && !(lakeId.Survey > 0))
                {
                    await tDataMapper.UpdateLakeList(lakeId, -1);
                    return;
                }

                var surveyId = await tDataMapper.LoadSurveyResult(surveyResult, lakeId);

                if (surveyId > 0)
                {
                    await tDataMapper.UpdateLakeList(lakeId, surveyId);
                }
            }
            catch (Exception e)
            {
                await tDataMapper.UpdateLakeList(lakeId, -2);
                Console.WriteLine($"Unable to get data for {lakeId.LakeId} ({lakeId.LakeName})");
                Console.WriteLine($"Exception: {e.Message}");
            }
        });
        
        endDate = DateTime.Now;
        
        Console.WriteLine(endDate - startDate);
    }
    

    public async Task ProcessLakes() // 00:30:58.6664180
    {
        startDate = DateTime.Now;

        var dataMapper = new DnrLakesDataMapper();
        await dataMapper.LoadFishTypes();

        await dataMapper.LoadLakes();

        var lakeList = dataMapper.GetLakes();
        
        foreach (var lakeId in lakeList)
        {
            Console.WriteLine($"Getting survey for {lakeId.LakeId} ({lakeId.LakeName}), {lakeId.County} County...");
            try
            {
                var surveyResult = await _apiClient.GetSurveyResponse(lakeId.LakeId);
                if (surveyResult.Status != "SUCCESS")
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
            catch (Exception e)
            {
                await dataMapper.UpdateLakeList(lakeId, -2);
                Console.WriteLine($"Unable to get data for {lakeId.LakeId} ({lakeId.LakeName})");
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
        
        endDate = DateTime.Now;
        
        Console.WriteLine(endDate - startDate);
    }
}
