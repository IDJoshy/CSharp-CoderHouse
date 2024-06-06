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
        public static List<Usuario> Bussiness_ObtenerUsuario(int idUsuario)
        {
            string _connection = ConnectionManager.SetConnection();
            return DataManager.Data_ObtenerUsuario(idUsuario, _connection);
        }

        public static List<Usuario> Bussiness_ListarUsuarios()
        {
            string _connection = ConnectionManager.SetConnection();
            return DataManager.Data_ListarUsuarios(_connection);
        }

        public static void Bussiness_CrearUsuario(Usuario usuario)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_CrearUsuario(usuario, _connection);
        }

        public static void Bussiness_ModificarUsuario(Usuario usuario)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_ModificarUsuario(usuario, _connection);
        }
        public static void Bussiness_EliminarUsuario(Usuario usuario)
        {
            string _connection = ConnectionManager.SetConnection();
            DataManager.Data_EliminarUsuario(usuario, _connection);
        }
    }
}
