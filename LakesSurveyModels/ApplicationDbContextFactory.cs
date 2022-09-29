using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LakesSurveyModels;

public static class ApplicationDbContextFactory
{
    public static ApplicationDbContext GetDbContext(string connectionString)
    {
        var lakeSurveyBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        lakeSurveyBuilder.UseNpgsql(connectionString);
        var dbContext = new ApplicationDbContext(lakeSurveyBuilder.Options);
        return dbContext;
    }

    public static ApplicationDbContext GetDbContext(IConfiguration config, string connectionName = "DefaultConnection")
    {
        var lakeSurveyBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        lakeSurveyBuilder.UseNpgsql(config.GetConnectionString(connectionName));
        var dbContext = new ApplicationDbContext(lakeSurveyBuilder.Options);
        return dbContext;
    }
}
