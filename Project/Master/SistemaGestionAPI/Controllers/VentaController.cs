using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet("GetVentas")]
        public IEnumerable<Venta> GetVentas()
        {
            return VentaBussiness.Bussiness_ListarVentas();
        }

        [HttpGet("GetVentaViaId/{id}")]
        public IActionResult GetVentaViaId(int id)
        {
            return Ok(VentaBussiness.Bussiness_ObtenerVenta(id));
        }

        [HttpPost("CreateVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.Bussiness_CrearVenta(venta);
        }

        [HttpPut("UpdateVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.Bussiness_ModificarVenta(venta);
        }

        [HttpDelete("DeleteVenta")]
        public void Delete([FromBody] Venta venta)
        {
            VentaBussiness.Bussiness_EliminarVenta(venta);
        }
    }
}
