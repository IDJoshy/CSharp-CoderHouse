using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> Bussiness_ObtenerProducto(int idProducto)
        {
            try
            {
                return DataManager.Data_ObtenerProducto(idProducto);
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener el Producto", e);
            }
        }

        public static List<Producto> Bussiness_ListarProductos()
        {
            try
            {
                return DataManager.Data_ListarProductos();
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar los Productos", e);
            }
            
        }

        public static void Bussiness_CrearProducto(Producto producto)
        {
            try
            {
                DataManager.Data_CrearProducto(producto);
            }
            catch (Exception e)
            {

                throw new Exception("Error al Crear el Producto", e);
            }
        }

        public static void Bussiness_ModificarProducto(Producto producto)
        {
            try
            { 
                DataManager.Data_ModificarProducto(producto);
            }
            catch (Exception e)
            {

                throw new Exception("Error al Modificar el Producto", e);
            }
        }

        public static void Bussiness_EliminarProducto(Producto producto)
        {
            try
            {
                DataManager.Data_EliminarProducto(producto);
            }
            catch (Exception e)
            {

                throw new Exception("Error al Eliminar el Producto", e);
            }
        }
    }


}
