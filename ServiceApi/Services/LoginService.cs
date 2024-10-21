namespace ServiceApi.Services
{
    // This is the class that implements the ILoginService interface.
    public class LoginService : ILoginService
    {
        // This method checks if the username and password are correct.
        // For simplicity, we hardcode the credentials here.
        public bool Login(string username, string password)
        {
            // Check if the username is "admin" and the password is "password"
            if (username == "admin" && password == "password")
            {
                // If they match, return true to indicate a successful login
                return true;
            }
            // Otherwise, return false
            return false;
        }
    }
}
