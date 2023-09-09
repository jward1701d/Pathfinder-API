using System.Net;

namespace Pathfinder_API.Models;

/// <summary>
/// Response Model used to return a response to the user.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <history>
///     [jward]     09/09/2023  Master: Created
/// </history>
public class Response<T>
{
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.NoContent; 
    public string Message { get; set; } = String.Empty;

    public T? Data { get; set; }
}
