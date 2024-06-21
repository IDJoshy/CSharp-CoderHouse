using SistemaGestionEntities;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public static class DataManager
    {

        private static string _connectionString;
        private static SqlConnection _connection;

        static DataManager()
        {
            DataManager._connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True;";
        }

        public static SqlConnection GetConnection()
        {
            if (DataManager._connection is null || DataManager._connection.State == System.Data.ConnectionState.Broken || DataManager._connection.State == System.Data.ConnectionState.Closed)
            {
                DataManager._connection = new SqlConnection(DataManager._connectionString);
            }


            DataManager._connection.Open();

            return DataManager._connection;
        }

        #region Producto
        public static List<Producto> Data_ObtenerProducto(int idProducto)
        {
            List<Producto> listProducto = ProductoData.ObtenerProducto(idProducto);
            return listProducto;
        }

        public static List<Producto> Data_ListarProductos()
        {
            List<Producto> listProductos = ProductoData.ListarProductos();
            return listProductos;
        }

        public static void Data_CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void Data_ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }

        public static void Data_EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }
        #endregion

        #region Producto Vendido
        public static List<ProductoVendido> Data_ObtenerProductoVendido(int idProductoVendido)
        {
            List<ProductoVendido> listProductoVendido = ProductoVendidoData.ObtenerProductoVendido(idProductoVendido);
            return listProductoVendido;
        }

        public static List<ProductoVendido> Data_ListarProductosVendidos()
        {
            List<ProductoVendido> listPoductosVendidos = ProductoVendidoData.ListarProductosVendidos();
            return listPoductosVendidos;
        }

        public static void Data_CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void Data_ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void Data_EliminarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }
        #endregion

        #region Venta
        public static List<Venta> Data_ObtenerVenta(int idVenta)
        {
            List<Venta> listVenta = VentaData.ObtenerVenta(idVenta);
            return listVenta;
        }

        public static List<Venta> Data_ListarVentas()
        {
            List<Venta> listVentas = VentaData.ListarVentas();
            return listVentas;
        }

        public static void Data_CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }
        public static void Data_ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
        public static void Data_EliminarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }
        #endregion

        #region Usuario

        public static bool Data_LogInUsuario(string name, string password)
        {
            bool usuarioLogIn = UsuarioData.LogInUsuario(name, password);
            return usuarioLogIn;
        }

        public static List<Usuario> Data_ObtenerUsuario(int idUsuario)
        {
            List<Usuario> listUsuario = UsuarioData.ObtenerUsuario(idUsuario);
            return listUsuario;
        }

        public static List<Usuario> Data_ListarUsuarios()
        {
            List<Usuario> listUsuarios = UsuarioData.ListarUsuarios();
            return listUsuarios;
        }

        public static void Data_CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }
        public static void Data_ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }
        public static void Data_EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);

        }
        #endregion
    }
}
