namespace Pathfinder_API.Interfaces;

/// <summary>
/// Mongo Database Settings Interface
/// </summary>
/// <history>
///     [jward]     09/09/23    Master: Created
/// </history>
public interface IMongoSettings
{
    /// <summary>User Collection Name</summary>
    String UserCollectionName { get; set; }

    /// <summary>Connection String</summary>
    String ConnectionString { get; set; }

    /// <summary>Database Name</summary>
    String DatabaseName { get; set; }
}