using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        private static string _connection;

        static VentaBussiness()
        {
            string _connection = BussinessManager.SetConnection();
        }

        public static List<Venta> Bussiness_ObtenerVenta(int idVenta)
        {
            return DataManager.Data_ObtenerVenta(idVenta, _connection);
        }

        public static List<Venta> Bussiness_ListarVentas()
        {
            return DataManager.Data_ListarVentas(_connection);
        }

        public static void Bussiness_CrearVenta(Venta venta)
        {
            DataManager.Data_CrearVenta(venta, _connection);
        }

        public static void Bussiness_ModificarVenta(Venta venta)
        {
            DataManager.Data_ModificarVenta(venta, _connection);
        }
        public static void Bussiness_EliminarVenta(Venta venta)
        {
            DataManager.Data_EliminarVenta(venta, _connection);
        }
    }
}
