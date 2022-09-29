using System.ComponentModel.DataAnnotations;

namespace LakesSurveyModels.Models;

public class Survey
{
    [Key]
    public int SurveyId { get; set; }
    public string SurveyNumber { get; set; }
    public string SurveyType { get; set; }
    public DateTime SurveyDate { get; set; }
    public string Narrative { get; set; }
    public List<Fish> Fish { get; set; }
    
    public Lake Lake { get; set; }
}

public enum SurveyType
{
    Standard = 1,
}

public enum SurveySubType
{
    PopulationAssessment = 1,
    ReSurvey = 2,
    InitialSurvey = 3,
    
}