using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        private static string _connection;

        static UsuarioBussiness()
        {
            string _connection = BussinessManager.SetConnection();
        }

        public static List<Usuario> Bussiness_ObtenerUsuario(int idUsuario)
        {
            return DataManager.Data_ObtenerUsuario(idUsuario, _connection);
        }

        public static List<Usuario> Bussiness_ListarUsuarios()
        {
            return DataManager.Data_ListarUsuarios(_connection);
        }

        public static void Bussiness_CrearUsuario(Usuario usuario)
        {
            DataManager.Data_CrearUsuario(usuario, _connection);
        }

        public static void Bussiness_ModificarUsuario(Usuario usuario)
        {
            DataManager.Data_ModificarUsuario(usuario, _connection);
        }
        public static void Bussiness_EliminarUsuario(Usuario usuario)
        {
            DataManager.Data_EliminarUsuario(usuario, _connection);
        }
    }
}
