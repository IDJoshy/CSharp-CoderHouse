using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    static class VentaData
    {
        // ObtenerVenta, ListarVentas, CrearVenta, ModificarVenta, EliminarVenta.

        internal static List<Venta> ObtenerVenta(int idVenta, string _connection)
        {
            List<Venta> listVenta = new List<Venta>();
            var query = @"SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id = @idVenta;";
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("idVenta", SqlDbType.Int) { Value = idVenta });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var venta = new Venta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Comentarios = reader["Comentarios"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };

                                listVenta.Add(venta);
                            }
                        }
                    }
                }
            }
            return listVenta;
        }

        internal static List<Venta> ListarVentas(string _connection)
        {
            List<Venta> listVentas = new List<Venta>();
            var query = @"SELECT Id,Comentarios, IdUsuario FROM Venta;";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var venta = new Venta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Comentarios = reader["Comentarios"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                listVentas.Add(venta);
                            }
                        }
                    }
                }
            }
            return listVentas;
        }

        internal static void CrearVenta(Venta venta, string _connection)
        {
            var query = @"INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Comentarios", venta.Comentarios));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", venta.IdUsuario));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Crear la Venta.");
                    }
                }
                connection.Close();
            }
        }

        internal static void ModificarVenta(Venta venta, string _connection)
        {
            var query = @"UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", venta.Id));
                    command.Parameters.Add(new SqlParameter("@Comentarios", venta.Comentarios));
                    command.Parameters.Add(new SqlParameter("@IdUsuario", venta.IdUsuario));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Modificar la Venta.");
                    }
                }
                connection.Close();
            }
        }

        internal static void EliminarVenta(Venta venta, string _connection)
        {
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", venta.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Eliminar la Venta.");
                    }
                }
                connection.Close();
            }
        }
    }
}

