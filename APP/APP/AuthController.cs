using System.Data;
using System.Runtime.InteropServices;

namespace SuaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;

        public AuthController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email AND senha = @Senha";
            var result = _dbConnection.ExecuteScalar<int>(query, new { request.Email, request.Senha });

            if (result > 0)
            {
                // Usuário autenticado com sucesso
                return Ok(new { Message = "Login bem-sucedido!" });
            }
            else
            {
                // Credenciais inválidas
                return Unauthorized(new { Message = "Credenciais inválidas!" });
            }
        }

        private IActionResult Unauthorized(object value)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(object value)
        {
            throw new NotImplementedException();
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
