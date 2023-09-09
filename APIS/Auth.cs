namespace Pathfinder_API.APIS;

public static class Auth
{
    public static void AuthRoutes(this WebApplication app, string url = "/api")
    {
        app.MapGet($"{url}/login", Login).WithOpenApi(); 
    }

    private static async Task<Response<String>> Login()
    {
        return new Response<String>() { Message = "Logged in", StatusCode = HttpStatusCode.OK, Data = null };
    }
}
