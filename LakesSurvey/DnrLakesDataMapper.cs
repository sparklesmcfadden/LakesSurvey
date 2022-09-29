using LakesSurvey.Models;
using LakesSurveyModels;
using LakesSurveyModels.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Lake = LakesSurveyModels.Models.Lake;
using Survey = LakesSurveyModels.Models.Survey;

namespace LakesSurvey;

public class DnrLakesDataMapper
{
    private ApplicationDbContext _context;
    
    public DnrLakesDataMapper()
    {
        var o1 = JObject.Parse(
            System.IO.File.ReadAllText(
                "/Users/cavanfarrell/RiderProjects/LakesSurvey/LakesSurvey/appsettings.json"));
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        builder.UseNpgsql(o1["ConnectionStrings"]["DefaultConnection"].Value<string>());
        _context = new ApplicationDbContext(builder.Options);
    }

    public async Task LoadFishTypes()
    {
        var fishMachine = new FishTypeMachine(_context);
        await fishMachine.LoadFishTypes();

    }

    public List<LakeIdList> GetLakes()
    {
        return _context.LakeList.ToList();
    }

    public async Task UpdateLakeList(LakeIdList lake, int survey)
    {
        lake.Survey = survey;
        _context.Update(lake);
        await _context.SaveChangesAsync();
    }

    public async Task LoadLakes()
    {
        var lakeList = await new DnrApiClient().GetCountyLakes();

        foreach (var lake in lakeList)
        {
            _context.LakeList.Add(lake);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<int> LoadSurveyResult(DnrLakeSurveyResponse<LakesSurvey.Models.Lake> lakeSurvey)
    {
        var surveys = new List<Survey>();

        lakeSurvey.Result.Surveys.ForEach(s =>
        {
            var fish = new List<Fish>();
            s.LengthsObj.ForEach(f =>
            {
                var lengthCounts = new List<LengthCount>();
                f.FishCount.ForEach(l =>
                {
                    lengthCounts.Add(new LengthCount
                    {
                        Length = l.Length,
                        Count = l.Count
                    });
                });
                fish.Add(new Fish
                {
                    FishSpecies = f.Species,
                    Lengths = lengthCounts,
                    MaximumLength = f.MaximumLength,
                    MinimumLength = f.MinimumLength
                });
            });
            
            surveys.Add(new Survey
            {
                SurveyNumber = s.SurveyId,
                SurveyType = s.SurveyType,
                SurveyDate = s.SurveyDate,
                Narrative = s.Narrative,
                Fish = fish
            });
        });
        
        var lake = new Lake
        {
            LakeId = lakeSurvey.Result.DOWNumber,
            LakeName = lakeSurvey.Result.LakeName,
            Acres = lakeSurvey.Result.AreaAcres,
            AverageDepth = lakeSurvey.Result.MeanDepthFeet,
            MaximumDepth = lakeSurvey.Result.MaxDepthFeet,
            Surveys = surveys
        };

        _context.Lakes.Add(lake);
        await _context.SaveChangesAsync();
        return lake.Id;
    }
}