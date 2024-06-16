using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {

        public static List<ProductoVendido> Bussiness_ObtenerProductoVendido(int idProducto)
        {
            try
            {
                return DataManager.Data_ObtenerProductoVendido(idProducto);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el Producto Vendido", e);
            }
        }

        public static List<ProductoVendido> Bussiness_ListarProductosVendidos()
        {
            try
            {
                return DataManager.Data_ListarProductosVendidos();
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar los Productos Vendidos", e);
            }
        }

        public static void Bussiness_CrearProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                DataManager.Data_CrearProductoVendido(productoVendido);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Añadir el Producto Vendido", e);
            }
        }

        public static void Bussiness_ModificarProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                DataManager.Data_ModificarProductoVendido(productoVendido);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar el Producto Vendido", e);
            }
            
        }

        public static void Bussiness_EliminarProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                DataManager.Data_EliminarProductoVendido(productoVendido);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar el Producto Vendido", e);
            }
            
        }
    }
}
