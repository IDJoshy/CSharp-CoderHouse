using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SistemaGestionData
{
    static class UsuarioData
    {
        internal static List<Usuario> ObtenerUsuario(int idUsuario)
        {
            List<Usuario> listUsuario = new List<Usuario>();
            string query = @"SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id = @idUsuario;";

            using (SqlConnection _connection = DataManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int) { Value = idUsuario });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var usuario = new Usuario
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    Contrasenia = reader["Contraseña"].ToString(),
                                    Mail = reader["Mail"].ToString()
                                };
                                listUsuario.Add(usuario);
                            }
                        }
                    }
                }
            }
            return listUsuario;
        }

        internal static List<Usuario> ListarUsuarios()
        {
            List<Usuario> listUsuarios = new List<Usuario>();
            string query = @"SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

            using (SqlConnection _connection = DataManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = reader["Nombre"].ToString();
                                usuario.Apellido = reader["Apellido"].ToString();
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Contrasenia = reader["Contraseña"].ToString();
                                usuario.Mail = reader["Mail"].ToString();
                                listUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            return listUsuarios;
        }

        internal static void CrearUsuario(Usuario usuario)
        {
            string query = @"INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection _connection = DataManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                    command.Parameters.Add(new SqlParameter("@Apellido", usuario.Apellido));
                    command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contrasenia));
                    command.Parameters.Add(new SqlParameter("@Mail", usuario.Mail));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo crear el usuario.");
                    }
                }
            }
        }

        internal static void ModificarUsuario(Usuario usuario)
        {
            string query = @"UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail WHERE Id = @Id";

            using (SqlConnection _connection = DataManager.GetConnection())
            {

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", usuario.Id));
                    command.Parameters.Add(new SqlParameter("@Nombre", usuario.Nombre));
                    command.Parameters.Add(new SqlParameter("@Apellido", usuario.Apellido));
                    command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contrasenia));
                    command.Parameters.Add(new SqlParameter("@Mail", usuario.Mail));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Modificar el Usuario.");
                    }
                }
            }
        }

        internal static void EliminarUsuario(Usuario usuario)
        {
            string query = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection _connection = DataManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", usuario.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Eliminar el Usuario.");
                    }
                }
            }
        }
    }
}
