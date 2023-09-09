namespace Pathfinder_API.Extensions;

public class AuthorizedAttribute : AuthorizeAttribute
{
    /// <summary>Authorized Attributed</summary>
    /// <param name="roles">Roles</param>
    /// <history>
    ///     [jward]     05/04/21    Master: Created
    /// </history>
    public AuthorizedAttribute(params Roles[] roles) : base()
    {
        Roles = String.Join(",", roles.Select(role => ((Roles)role).AsString(EnumFormat.Description)));
    }

    /// <summary>Authorized Attributed</summary>
    /// <param name="role">Role</param>
    /// <history>
    ///     [jward]     05/04/21    Master: Created
    /// </history>
    public AuthorizedAttribute(Roles role) : base()
    {
        Roles = ((Roles)role).AsString(EnumFormat.Description);
    }
}