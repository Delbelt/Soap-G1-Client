using Microsoft.AspNetCore.Mvc;
using soap_client.Services;

namespace soap_client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("insertUserFile")]
        public async Task<IActionResult> CargarUsuarios(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Please, upload a valid Excel file..");
            }

            try
            {
                
                byte[] fileBytes;
                using (var ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    fileBytes = ms.ToArray();
                }

                var resultado = await _userService.CargarUsuariosAsync(fileBytes);

                var response = new
                {
                    UsuariosCargados = resultado.CargarUsuariosResponse.usuariosCargados,
                    Errores = resultado.CargarUsuariosResponse.errores
                };

               
                if (resultado.CargarUsuariosResponse.errores != null && resultado.CargarUsuariosResponse.errores.Length > 0)
                {
                    return Ok(new { Mensaje = "Errors found loading users", Detalles = response });
                }

                _logger.LogInformation("[UserController][CargarUsuarios]: Usuarios cargados correctamente.");

                return Ok(response); 
            }
            catch (Exception ex)
            {
                _logger.LogError("[UserController][CargarUsuarios]: {message}", ex.Message);

                return BadRequest($"Error loading users: {ex.Message}");
            }
        }

    }
}
