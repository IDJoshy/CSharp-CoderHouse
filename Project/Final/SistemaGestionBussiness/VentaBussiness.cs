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
        public static List<Venta> Bussiness_ObtenerVenta(int idVenta)
        {
            string _connection = BussinessManager.SetConnection();
            return DataManager.Data_ObtenerVenta(idVenta, _connection);
        }

        public static List<Venta> Bussiness_ListarVentas()
        {
            string _connection = BussinessManager.SetConnection();
            return DataManager.Data_ListarVentas(_connection);
        }

        public static void Bussiness_CrearVenta(Venta venta)
        {
            string _connection = BussinessManager.SetConnection();
            DataManager.Data_CrearVenta(venta, _connection);
        }

        public static void Bussiness_ModificarVenta(Venta venta)
        {
            string _connection = BussinessManager.SetConnection();
            DataManager.Data_ModificarVenta(venta, _connection);
        }
        public static void Bussiness_EliminarVenta(Venta venta)
        {
            string _connection = BussinessManager.SetConnection();
            DataManager.Data_EliminarVenta(venta, _connection);
        }
    }
}
