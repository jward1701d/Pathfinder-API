namespace Pathfinder_API.Extensions;

/// <summary>Linq Extensions</summary>
/// <history>
///     [jward]     09/09/23    Master: Created
/// </history>
public static class LinqExtensions
{
    /// <summary>As Empty If Null</summary>
    /// <param name="data">Data</param>
    /// <returns>returns empty object</returns>
    /// <history>
    ///     [jward]     09/09/23    Master: Created
    /// </history>
    public static IQueryable<T> AsEmptyIfNull<T>(this IQueryable<T> data)
    {
        return data.Count() == 0 ? new List<T>().AsQueryable() : data;
    }

    /// <summary>Is Empty Or Null</summary>
    /// <param name="data">Data</param>
    /// <returns>true/fasle</returns>
    /// <history>
    ///     [jward]     09/09/23    Master: Created
    /// </history>
    public static Boolean IsEmptyOrNull<T>(this IEnumerable<T> data)
    {
        return data.Count() == 0 ? true : false;
    }
}
