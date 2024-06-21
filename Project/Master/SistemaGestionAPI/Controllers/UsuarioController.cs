using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Xml.Linq;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("GetUsuarioLogIn/{name, password}")]
        public IActionResult GetUsuarioLogIn(string name, string password)
        {
            bool usuarioLogged = UsuarioBussiness.Bussiness_LogInUsuario(name, password);

            return Ok(usuarioLogged);
        }

        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> GetUsuario()
        {
            return UsuarioBussiness.Bussiness_ListarUsuarios().ToArray();
        }

        [HttpGet("GetUsuarioViaId/{id}")]
        public IActionResult GetUsuarioViaId(int id)
        {
            List<Usuario> usuario = UsuarioBussiness.Bussiness_ObtenerUsuario(id);

            return Ok(usuario);
        }

        [HttpPost("CreateUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.Bussiness_CrearUsuario(usuario);
        }

        [HttpPut("UpdateUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.Bussiness_ModificarUsuario(usuario);
        }

        [HttpDelete("DeleteUsuario")]
        public void Delete([FromBody] Usuario usuario)
        {
            UsuarioBussiness.Bussiness_EliminarUsuario(usuario);
        }
    }
}
