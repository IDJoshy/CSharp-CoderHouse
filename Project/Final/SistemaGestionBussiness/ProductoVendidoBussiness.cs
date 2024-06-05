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
        private static string _connection;

        static ProductoVendidoBussiness()
        {
            string _connection = BussinessManager.SetConnection();
        }

        public static List<ProductoVendido> Bussiness_ObtenerProductoVendido(int idProducto)
        {
            return DataManager.Data_ObtenerProductoVendido(idProducto, _connection);
        }

        public static List<ProductoVendido> Bussiness_ListarProductosVendidos()
        {
            return DataManager.Data_ListarProductosVendidos(_connection);
        }

        public static void Bussiness_CrearProductoVendido(ProductoVendido productoVendido)
        {
            DataManager.Data_CrearProductoVendido(productoVendido, _connection);
        }

        public static void Bussiness_ModificarProductoVendido(ProductoVendido productoVendido)
        {
            DataManager.Data_ModificarProductoVendido(productoVendido, _connection);
        }
        public static void Bussiness_EliminarProducto(ProductoVendido productoVendido)
        {
            DataManager.Data_EliminarProductoVendido(productoVendido, _connection);
        }
    }
}
