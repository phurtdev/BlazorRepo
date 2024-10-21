using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebClient.Services
{
    // This class implements the ILoginService interface to handle login logic on the client-side.
    public class LoginService : ILoginService
    {
        private readonly HttpClient _httpClient;

        // Constructor that takes an HttpClient. The HttpClient will be used to communicate with the backend API.
        public LoginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // This method sends a login request to the API and returns true or false depending on success.
        public async Task<bool> Login(string username, string password)
        {
            // Create an object with the username and password to send to the API.
            var loginModel = new { Username = username, Password = password };

            // Send a POST request to the backend API's login endpoint.
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginModel);

            // If the response status code is "OK", return true; otherwise, return false.
            return response.IsSuccessStatusCode;
        }
    }
}
