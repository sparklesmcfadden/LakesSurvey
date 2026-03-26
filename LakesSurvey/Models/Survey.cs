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
    public HeaderInfo HeaderInfo { get; set; }
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

public class HeaderInfo
{
    public string Wb_type { get; set; }
    public string Wb_id { get; set; }
    public string Survey_type { get; set; }
    public string County { get; set; }
    public string Wb_alt_name { get; set; }
    public string Wb_name { get; set; }
    public string Id_date { get; set; }
    public string Survey_id { get; set; }
}