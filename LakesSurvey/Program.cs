using LakesSurvey;
using LakesSurveyModels.Models;

var surveyProcessor = new SurveyProcessor();
await surveyProcessor.ProcessLakesParallel();
