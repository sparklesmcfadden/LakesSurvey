using System.ComponentModel.DataAnnotations;

namespace LakesSurveyModels.Models;

public class Lake
{
    [Key]
    public int Id { get; set; }
    public string LakeId { get; set; }
    public string LakeName { get; set; }
    public decimal Acres { get; set; }
    public decimal AverageDepth { get; set; }
    public decimal MaximumDepth { get; set; }
    public List<Survey> Surveys { get; set; }
}