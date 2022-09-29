namespace LakesSurvey.Models;

public class FishCatchSummary
{
    public int TotalCatch { get; set; }
    public decimal TotalWeight { get; set; }
    public string? AverageWeight { get; set; }
    public string? QuartileWeight { get; set; }
    public string? CPUE { get; set; }
    public string? QuartileCount { get; set; }
    public string? Gear { get; set; }
    public decimal GearCount { get; set; }
    public string? Species { get; set; }
}