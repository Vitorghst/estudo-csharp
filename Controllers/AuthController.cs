using Microsoft.AspNetCore.Mvc;

namespace ListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("validate")]
        public IActionResult ValidateUser([FromBody] User credentials)
        {
            bool isValid = _authService.IsValidUser(credentials.Username, credentials.Password);
            if (isValid)
            {
                return Ok("User is valid");
            }
            else
            {
                return Unauthorized("Invalid credentials");
            }
        }

        [HttpGet("getUser")]
        public IActionResult GetUser(string username)
        {
            var user = _authService.GetUser(username);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound("User not found");
            }
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(User request)
        {
            if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Dados do usuário inválidos.");
            }

            bool userAdded = _authService.AddUser(request.Username, request.Password);

            if (userAdded)
            {
                return Ok("Usuário adicionado com sucesso.");
            }
            else
            {
                return Conflict("O usuário já existe.");
            }
        }
    }

    // Classe para representar o corpo da requisição


    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
