using Newtonsoft.Json.Linq;

namespace LakesSurvey.Models;

public class Survey
{
    public string SurveyId { get; set; }
    public JObject Lengths { get; set; }
    public List<Lengths> LengthsObj { get; set; }
    public string SurveySubType { get; set; }
    public List<FishCatchSummary> FishCatchSummaries { get; set; }
    public string Narrative { get; set; }
    public List<string> HeaderInfo { get; set; }
    public string SurveyType { get; set; }
    public DateTime SurveyDate { get; set; }
}

public class Lengths
{
    public string Species { get; set; }
    public int MaximumLength { get; set; }
    public int MinimumLength { get; set; }
    public List<FishCount> FishCount { get; set; }
}

public class FishCount
{
    public int Length { get; set; }
    public int Count { get; set; }
}