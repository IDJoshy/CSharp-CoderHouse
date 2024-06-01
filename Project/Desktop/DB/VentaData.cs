﻿using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Desktop.DB
{
    public static class VentaData
    {
        private static string _connection;

        static VentaData()
        {
            _connection = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True;";
        }

        // ObtenerVenta, ListarVentas, CrearVenta, ModificarVenta, EliminarVenta.

        public static List<Venta> ObtenerVenta(int idVenta)
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

        public static List<Venta> ListarVentas()
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

        public static void CrearVenta(Venta venta)
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

        public static void ModificarVenta(Venta venta)
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

        public static void EliminarVenta(Venta venta)
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
