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
        public static bool Bussiness_LogInUsuario(string name, string password)
        {
            try 
            {
                bool userLogged = DataManager.Data_LogInUsuario(name, password);

                if (userLogged) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al iniciar sesión", e);
            }

        }

        public static List<Usuario> Bussiness_ObtenerUsuario(int idUsuario)
        {
            try
            {
                return DataManager.Data_ObtenerUsuario(idUsuario);
            }
            catch (Exception e) 
            {
                throw new Exception("Error al obtener el Usuario", e);
            }
        }

        public static List<Usuario> Bussiness_ListarUsuarios()
        {
            try
            {
                return DataManager.Data_ListarUsuarios();
            }
            catch (Exception e) 
            {
                throw new Exception("Error al Listar Usuarios", e);
            }
            
        }

        public static void Bussiness_CrearUsuario(Usuario usuario)
        {
            try
            {
                DataManager.Data_CrearUsuario(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Crear Usuario", e);
            }
            
        }

        public static void Bussiness_ModificarUsuario(Usuario usuario)
        {
            try
            {
                DataManager.Data_ModificarUsuario(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Modificar al Usuario", e);
            }
            
        }

        public static void Bussiness_EliminarUsuario(Usuario usuario)
        {
            try
            {
                DataManager.Data_EliminarUsuario(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Error al Eliminar al Usuario", e);
            } 
        }
    }
}
