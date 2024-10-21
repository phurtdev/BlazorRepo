namespace WebClient.Services
{
    // This interface defines the login functionality for the Blazor client-side.
    public interface ILoginService
    {
        // This method will attempt to log the user in and return true or false based on success.
        Task<bool> Login(string username, string password);
    }
}
