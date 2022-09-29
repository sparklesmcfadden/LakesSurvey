namespace LakesSurvey.Models;

public class Lake
{
    public List<Access> Accesses { get; set; }
    public decimal LittoralAcres { get; set; }
    public List<object> WaterClarity { get; set; }
    public string AverageWaterClarity { get; set; }
    public string LakeName { get; set; }
    public decimal ShoreLengthMiles { get; set; }
    public List<object> SampledPlants { get; set; }
    public decimal AreaAcres { get; set; }
    public string DOWNumber { get; set; }
    public decimal MeanDepthFeet { get; set; }
    public List<Survey> Surveys { get; set; }
    public string OfficeCode { get; set; }
    public decimal MaxDepthFeet { get; set; }
}