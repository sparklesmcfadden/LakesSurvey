using System.ComponentModel.DataAnnotations;

namespace LakesSurveyModels.Models;

public class Fish
{
    [Key]
    public int FishId { get; set; }
    public string FishSpecies { get; set; }
    public List<LengthCount> Lengths { get; set; }
    public int MaximumLength { get; set; }
    public int MinimumLength { get; set; }
    
    public Survey Survey { get; set; }
}

public class LengthCount
{
    [Key]
    public int LengthCountId { get; set; }
    public int Length { get; set; }
    public int Count { get; set; }
    public Fish Fish { get; set; }
}

public class FishType
{
    [Key]
    public int FishTypeId { get; set; }
    public string FishShortName { get; set; }
    public string FishLongName { get; set; }
}