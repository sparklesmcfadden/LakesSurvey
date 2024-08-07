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
    private readonly ApplicationDbContext _context;
    
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

    public async Task UpdateLakeList(LakeIdList lake, long survey)
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
            if (_context.LakeList.Any(l => l.LakeId == lake.LakeId))
            {
                continue;
            }
            _context.LakeList.Add(lake);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<Survey>> GetSurveys(string lakeId)
    {
        return await _context.Surveys.Include(s => s.Lake)
            .Where(s => s.Lake.LakeId == lakeId).ToListAsync();
    }

    public bool SurveyExists(string surveyNumber)
    {
        return _context.Surveys.Any(s => s.SurveyNumber == surveyNumber);
    }

    public async Task<long> LoadSurveyResult(DnrLakeSurveyResponse<LakesSurvey.Models.Lake> lakeSurvey, LakeIdList lakeId)
    {
        var surveys = new List<Survey>();
        long lastSurveyId = 0;

        foreach (var survey in lakeSurvey.Result.Surveys)
        {
            if (SurveyExists(survey.SurveyId))
            {
                continue;
            }
            var fish = new List<Fish>();
            survey.LengthsObj.ForEach(f =>
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

            var newSurvey = new Survey
            {
                SurveyNumber = survey.SurveyId,
                SurveyType = survey.SurveyType,
                SurveyDate = survey.SurveyDate,
                Narrative = survey.Narrative,
                Fish = fish
            };
            
            surveys.Add(newSurvey);
        }

        var lake = new Lake
        {
            LakeId = lakeSurvey.Result.DOWNumber,
            LakeName = lakeSurvey.Result.LakeName ?? lakeId.LakeName,
            Acres = lakeSurvey.Result.AreaAcres,
            AverageDepth = lakeSurvey.Result.MeanDepthFeet,
            MaximumDepth = lakeSurvey.Result.MaxDepthFeet,
            Surveys = surveys
        };
        
        var existingLake = await _context.Lakes.FirstOrDefaultAsync(l => l.LakeId == lake.LakeId);
        if (existingLake != null)
        {
            existingLake.Surveys = surveys;
            _context.Lakes.Update(existingLake);
            await _context.SaveChangesAsync();
            return 0;
        }
        
        _context.Lakes.Add(lake);
        await _context.SaveChangesAsync();
        
        lastSurveyId = surveys.Any() ? surveys.MaxBy(s => s.SurveyDate)!.SurveyId : 0;
        return lastSurveyId;
    }
}