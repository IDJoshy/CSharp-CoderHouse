using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SistemaGestionBussiness;
using SistemaGestionEntities;


namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("GetProductosVendidos")]
        public IEnumerable<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoBussiness.Bussiness_ListarProductosVendidos();
        }

        [HttpGet("GetProductoVendidoViaId/{id}")]
        public IActionResult GetProductoVendidoViaId(int id)
        {
            return Ok(ProductoVendidoBussiness.Bussiness_ObtenerProductoVendido(id));
        }

        [HttpPost("CreateProducto")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.Bussiness_CrearProductoVendido(productoVendido);
        }

        [HttpPut("UpdateProducto")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.Bussiness_ModificarProductoVendido(productoVendido);
        }

        [HttpDelete("DeleteProducto")]
        public void Delete([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.Bussiness_EliminarProductoVendido(productoVendido);
        }
    }
}
