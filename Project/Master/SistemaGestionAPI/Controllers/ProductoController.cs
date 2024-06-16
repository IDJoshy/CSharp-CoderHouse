using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SistemaGestionBussiness;
using SistemaGestionEntities;


namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("GetProductos")]
        public IEnumerable<Producto> GetProductos()
        {
            return ProductoBussiness.Bussiness_ListarProductos().ToArray();
        }

        [HttpGet("GetProductoViaId/{id}")]
        public IActionResult GetProductoViaId(int id)
        {
            return Ok(ProductoBussiness.Bussiness_ObtenerProducto(id));
        }

        [HttpPost("CreateProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.Bussiness_CrearProducto(producto);
        }

        [HttpPut("UpdateProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.Bussiness_ModificarProducto(producto);
        }

        [HttpDelete("DeleteProducto")]
        public void Delete([FromBody] Producto producto)
        {
            ProductoBussiness.Bussiness_EliminarProducto(producto);
        }
    }
}
