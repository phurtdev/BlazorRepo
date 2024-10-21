using Microsoft.AspNetCore.Mvc;
using ServiceApi.Services;

namespace ServiceApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    // This is the controller that will handle API requests related to authentication (login).
    public class AuthController : ControllerBase
    {
        // We use dependency injection to get an instance of ILoginService (our login service).
        private readonly ILoginService _loginService;

        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        // This is the API endpoint for login.
        // It listens for POST requests at "api/auth/login".
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Call the login service to check if the username and password are correct.
            if (_loginService.Login(request.Username, request.Password))
            {
                // If successful, return an "OK" response with a success message.
                return Ok(new { message = "Login successful!" });
            }

            // If login failed, return an "Unauthorized" response.
            return Unauthorized(new { message = "Login failed!" });
        }
    }

    // This class represents the data that the client (Blazor WebAssembly) will send when logging in.
    // It contains the username and password.
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
