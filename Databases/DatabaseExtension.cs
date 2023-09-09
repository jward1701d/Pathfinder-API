namespace Pathfinder_API.Databases;

public static class DatabaseExtension
{
    /// <summary>Configure Database</summary>
    /// <param name="services">Services</param>
    /// <param name="configuration">Configuration</param>
    /// <history>
    ///     [jward]     09/09/23    Master: Created
    /// </history>
    public static void ConfigureMongoDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        // Setup connection to MongoDB
        services.Configure<MongoSettings>(
            configuration.GetSection(nameof(MongoSettings)));
        services.AddSingleton<IMongoSettings>(provider =>
            provider.GetRequiredService<IOptions<MongoSettings>>().Value);
    }
}
