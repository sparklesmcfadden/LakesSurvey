using LakesSurvey.Models;
using LakesSurveyModels;
using LakesSurveyModels.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Lake = LakesSurvey.Models.Lake;

namespace LakesSurvey;

public class DnrApiClient
{
    private readonly HttpClient _client;

    public DnrApiClient()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
        _client = new HttpClient(clientHandler);
    }

    public async Task<DnrLakeSurveyResponse<Lake>> GetSurveyResponse(string lakeId)
    {
        var url = "https://maps2.dnr.state.mn.us/cgi-bin/lakefinder/detail.cgi?type=lake_survey&id=" + lakeId;

        var response = await _client.GetAsync(url);
        var contentString = await response.Content.ReadAsStringAsync();
        
        if (!string.IsNullOrEmpty(contentString))
        {
            var content = JsonConvert.DeserializeObject<DnrLakeSurveyResponse<Lake>>(contentString);

            content?.Result?.Surveys.ForEach(s =>
            {
                var lengths = new List<Lengths>();
                foreach (var item in s.Lengths)
                {
                    var counts = new List<FishCount>();
                    foreach (var count in item.Value["fishCount"])
                    {
                        counts.Add(new FishCount
                        {
                            Count = (int)count[1],
                            Length = (int)count[0]
                        });
                    }
                        
                    lengths.Add(new Lengths
                    {
                        Species = item.Key,
                        MaximumLength = (int)item.Value["maximum_length"],
                        MinimumLength = (int)item.Value["minimum_length"],
                        FishCount = counts
                    });
                }

                s.LengthsObj = lengths;
            });

            return content;
        }

        return new DnrLakeSurveyResponse<Lake>
        {
            Message = "No results",
            Timestamp = 0,
            Status = "No results"
        };
    }

    public async Task<List<LakeIdList>> GetCountyLakes()
    {
        var lakes = new List<LakeIdList>();
        
        for (int i = 1; i <= 87; i++)
        {
            Console.WriteLine(i);
            var url = "https://maps2.dnr.state.mn.us/cgi-bin/lakefinder_json.cgi?county=" + i;

            var response = await _client.GetAsync(url);
            var contentString = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(contentString))
            {
                var content = JsonConvert.DeserializeObject<DnrLakeResponse<JArray>>(contentString);

                if (content.Status == "ERROR") continue;

                foreach (var lake in content.Results)
                {
                    var latitude = (double)lake["point"]["epsg:4326"][1];
                    var longitude = (double)lake["point"]["epsg:4326"][0];
                    var distance = GetDistance(longitude, latitude);
                    
                    var LakeInfo = new LakeIdList
                    {
                        LakeId = (string)lake["id"],
                        LakeName = (string)lake["name"],
                        City = (string)lake["nearest_town"],
                        County = (string)lake["county"],
                        Coordinates = $"{(string)lake["point"]["epsg:4326"][0]}, {(string)lake["point"]["epsg:4326"][1]}",
                        Distance = distance
                    };

                    lakes.Add(LakeInfo);
                }
            }
        }

        return lakes;
    }
    
    public double GetDistance(double longitude, double latitude)
    {
        var otherLatitude = 44.88564596459762;
        var otherLongitude = -93.05245205103621;
        
        var d1 = latitude * (Math.PI / 180.0);
        var num1 = longitude * (Math.PI / 180.0);
        var d2 = otherLatitude * (Math.PI / 180.0);
        var num2 = otherLongitude * (Math.PI / 180.0) - num1;
        var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
    
        return 3963.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
    }
}
