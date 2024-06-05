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
        private static string _connection;

        static ProductoBussiness() 
        {
            string _connection = BussinessManager.SetConnection();
        }

        public static List<Producto> Bussiness_ObtenerProducto(int idProducto)
        {
            return DataManager.Data_ObtenerProducto(idProducto, _connection); 
        }

        public static List<Producto> Bussiness_ListarProductos()
        {
            return DataManager.Data_ListarProductos(_connection);
        }

        public static void Bussiness_CrearProducto(Producto producto)
        {
            DataManager.Data_CrearProducto(producto, _connection);
        }

        public static void Bussiness_ModificarProducto(Producto producto)
        {
            DataManager.Data_ModificarProducto(producto, _connection);
        }
        public static void Bussiness_EliminarProducto(Producto producto)
        {
            DataManager.Data_EliminarProducto(producto, _connection);
        }
    }


}
