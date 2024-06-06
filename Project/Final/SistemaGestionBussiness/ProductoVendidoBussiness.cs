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
            string _connection = ConnectionManager.SetConnection();
            return DataManager.Data_ObtenerProductoVendido(idProducto, _connection);
        }

        public static List<ProductoVendido> Bussiness_ListarProductosVendidos()
        {
            string _connection = ConnectionManager.SetConnection();
            return DataManager.Data_ListarProductosVendidos(_connection);
        }

        public static void Bussiness_CrearProductoVendido(ProductoVendido productoVendido)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_CrearProductoVendido(productoVendido, _connection);
        }

        public static void Bussiness_ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_ModificarProductoVendido(productoVendido, _connection);
        }
        public static void Bussiness_EliminarProducto(ProductoVendido productoVendido)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_EliminarProductoVendido(productoVendido, _connection);
        }
    }
}
