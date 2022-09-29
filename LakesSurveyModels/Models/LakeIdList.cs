namespace LakesSurveyModels.Models;

public class LakeIdList
{
    public int Id { get; set; }
    public string LakeId { get; set; }
    public string LakeName { get; set; }
    public string City { get; set; }
    public string County { get; set; }
    public string Coordinates { get; set; }
    public int Survey { get; set; }
    public double Distance { get; set; }
}