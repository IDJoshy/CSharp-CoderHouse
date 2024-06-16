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
            try
            {
                return DataManager.Data_ObtenerVenta(idVenta);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Obtener Venta", e);
            }
            
        }

        public static List<Venta> Bussiness_ListarVentas()
        {
            try
            {
                return DataManager.Data_ListarVentas();
            }
            catch (Exception e)
            {
                throw new Exception("Error al Listar Ventas", e);
            }
            
        }

        public static void Bussiness_CrearVenta(Venta venta)
        {
            try
            {
                DataManager.Data_CrearVenta(venta);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Crear Venta", e);
            }
        }

        public static void Bussiness_ModificarVenta(Venta venta)
        {
            try
            {
                DataManager.Data_ModificarVenta(venta);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar Venta", e);
            }
            
        }
        public static void Bussiness_EliminarVenta(Venta venta)
        {
            try
            {
                DataManager.Data_EliminarVenta(venta);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar Venta", e);
            }
            
        }
    }
}
