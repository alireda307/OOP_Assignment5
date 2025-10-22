namespace RunProgram.Interfaces;

public class BasicAuthenticationService : IAuthenticationService
{
    private readonly Dictionary<string, (string Password, string Role)> Users = new Dictionary<string, (string, string)>
    {
        { "admin", ("admin123", "Administrator") },
        { "user", ("user123", "User") }
    };
    
    public bool AuthenticateUser(string username, string password)
    {
        if (Users.ContainsKey(username) && Users[username].Password == password)
        {
            return true;
        }
        return false;
    }
    
    public bool AuthorizeUser(string username, string role)
    {
        if (Users.ContainsKey(username) && Users[username].Role == role)
        {
            return true;
        }
        return false;
    }
}