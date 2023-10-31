using ApiAuth.Infrastructure.Security;
using ApiAuth.Models;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IConfiguration config, ILogger<LoginController> logger)
        {
            _config = config;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(
            [FromBody] Credencial credenciais,
            [FromServices] ILoginService loginService)
        {
            try
            {
                Usuario _usuario = loginService.Autentica(credenciais);

                if (_usuario == null)
                    return NoContent();

                _logger.LogInformation($"Login efetuado pelo usuario: {JsonSerializer.Serialize(_usuario)}");

                return Ok(new {
                            token = JwtToken.GenerateToken(_usuario, _config),
                            usuario = _usuario
                        }); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
