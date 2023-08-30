using Microsoft.AspNetCore.Mvc;
using MM_Models.Api.Command;
using MM_Models.Api.Repositories;
using MM_Models.Api.Entities;
using MM_Models.Api.Queries;
using Tools.CQS.Command;
using MM_API.Forms;

namespace MM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        private readonly ILogger _logger;

        public AuthController(IAuthRepository authRepository, ILogger<AuthController> logger)
        {
            _authRepository = authRepository;
            _logger = logger;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterForm form)
        {
            _logger.LogInformation($"New User Registered : {form.FirstName} {form.LastName} as {form.UserName} ({form.Email}) ");
            ICommandResult result = _authRepository.Execute(new RegisterCommand(form.FirstName, form.LastName, form.UserName, form.Email, form.BirthDate, form.Password));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }


            return NoContent();
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginForm form)
        {
            _logger.LogInformation($"Nouvel demande d'authentification : {form.Email}");
            User? utilisateur = _authRepository.Execute(new LoginQuery(form.UserName, form.Email, form.Password));

            if (utilisateur is null)
            {
                _logger.LogWarning("Utilisateur Not Found");
                return NotFound();
            }

            return Ok(utilisateur);

        }

    }
}
