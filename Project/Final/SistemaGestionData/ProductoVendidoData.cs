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
     static class ProductoVendidoData
     {
        internal static List<ProductoVendido> ObtenerProductoVendido(int idProductoVendido, string _connection)
        {
            List<ProductoVendido> listProductoVendido = new List<ProductoVendido>();
            var query = @"SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido WHERE Id = @idProductoVendido;";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("idProductoVendido", SqlDbType.Int) { Value = idProductoVendido });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdVenta = Convert.ToInt32(reader["IdVenta"])
                                };
                                listProductoVendido.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return listProductoVendido;
        }

        internal static List<ProductoVendido> ListarProductosVendidos(string _connection)
        {
            List<ProductoVendido> listProductosVendidos = new List<ProductoVendido>();
            var query = @"SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido;";

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
                                var productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    IdVenta = Convert.ToInt32(reader["IdVenta"])
                                };
                                listProductosVendidos.Add(productoVendido);
                            }
                        }
                    }
                }
            }
            return listProductosVendidos;
        }
        internal static void CrearProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            var query = @"INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES (@Stock, @IdProducto, @IdVenta)";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Stock", productoVendido.Stock));
                    command.Parameters.Add(new SqlParameter("@IdProducto", productoVendido.IdProducto));
                    command.Parameters.Add(new SqlParameter("@IdVenta", productoVendido.IdVenta));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible crear un Producto Vendido.");
                    }
                }
                connection.Close();
            }
        }

        internal static void ModificarProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            var query = @"UPDATE ProductoVendido SET Stock = @Stock, IdProducto = @IdProducto, IdVenta = @IdVenta WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", productoVendido.Id));
                    command.Parameters.Add(new SqlParameter("@Stock", productoVendido.Stock));
                    command.Parameters.Add(new SqlParameter("@IdProducto", productoVendido.IdProducto));
                    command.Parameters.Add(new SqlParameter("@IdVenta", productoVendido.IdVenta));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Modificar el Producto Vendido.");
                    }
                }
                connection.Close();
            }
        }

        internal static void EliminarProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", productoVendido.Id));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No fue posible Eliminar el Producto Vendido.");
                    }
                }
                connection.Close();
            }
        }
     }
}

