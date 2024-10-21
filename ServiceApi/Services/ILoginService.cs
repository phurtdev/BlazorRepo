namespace ServiceApi.Services
{
    // This interface defines the methods that our LoginService must implement.
    public interface ILoginService
    {
        // Method that will handle login functionality. It takes a username and password.
        bool Login(string username, string password);
    }
}

