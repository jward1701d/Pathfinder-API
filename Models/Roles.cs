namespace Pathfinder_API.Models;

/// <summary>Roles</summary>
/// <history>
///     [jward]     09/04/23    Master: Created
/// </history>
public enum Roles
{
    /// <summary>None</summary>
    [Description("none")]
    None,

    /// <summary>Admin</summary>
    [Description("admin")]
    Admin,

    /// <summary>User</summary>
    [Description("user")]
    User
}
