namespace Pathfinder_API.Databases;

/// <summary>Database Settings</summary>
/// <history>
///     [jward]     09/09/23    Master: Created
/// </history>
public class MongoSettings : IMongoSettings
{
    public string UserCollectionName { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
}

