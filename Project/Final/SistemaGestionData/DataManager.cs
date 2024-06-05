using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class DataManager
    {
        #region Producto
        public static List<Producto> Data_ObtenerProducto(int idProducto, string _connection)
        {
            List<Producto> listProducto = ProductoData.ObtenerProducto(idProducto, _connection);
            return listProducto;
        }

        public static List<Producto> Data_ListarProductos(string _connection)
        {
            List<Producto> listProductos = ProductoData.ListarProductos(_connection);
            return listProductos;
        }

        public static void Data_CrearProducto(Producto producto, string _connection)
        {
            ProductoData.CrearProducto(producto, _connection);
        }

        public static void Data_ModificarProducto(Producto producto, string _connection)
        {
            ProductoData.ModificarProducto(producto, _connection);
        }

        public static void Data_EliminarProducto(Producto producto, string _connection)
        {
            ProductoData.EliminarProducto(producto, _connection);
        }
        #endregion

        #region Producto Vendido
        public static List<ProductoVendido> Data_ObtenerProductoVendido(int idProductoVendido, string _connection)
        {
            List<ProductoVendido> listProductoVendido = ProductoVendidoData.ObtenerProductoVendido(idProductoVendido, _connection);
            return listProductoVendido;
        }

        public static List<ProductoVendido> Data_ListarProductosVendidos(string _connection)
        {
            List<ProductoVendido> listPoductosVendidos = ProductoVendidoData.ListarProductosVendidos(_connection);
            return listPoductosVendidos;
        }

        public static void Data_CrearProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido, _connection);
        }
        public static void Data_ModificarProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido, _connection);
        }
        public static void Data_EliminarProductoVendido(ProductoVendido productoVendido, string _connection)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido, _connection);
        }
        #endregion

        #region Venta
        public static List<Venta> Data_ObtenerVenta(int idVenta, string _connection)
        {
            List<Venta> listVenta = VentaData.ObtenerVenta(idVenta, _connection);
            return listVenta;
        }

        public static List<Venta> Data_ListarVentas(string _connection)
        {
            List<Venta> listVentas = VentaData.ListarVentas(_connection);
            return listVentas;
        }

        public static void Data_CrearVenta(Venta venta, string _connection)
        {
            VentaData.CrearVenta(venta, _connection);
        }
        public static void Data_ModificarVenta(Venta venta, string _connection)
        {
            VentaData.ModificarVenta(venta, _connection);
        }
        public static void Data_EliminarVenta(Venta venta, string _connection)
        {
            VentaData.EliminarVenta(venta, _connection);
        }
        #endregion

        #region Usuario
        public static List<Usuario> Data_ObtenerUsuario(int idUsuario, string _connection)
        {
            List<Usuario> listUsuario = UsuarioData.ObtenerUsuario(idUsuario, _connection);
            return listUsuario;
        }

        public static List<Usuario> Data_ListarUsuarios(string _connection)
        {
            List<Usuario> listUsuarios = UsuarioData.ListarUsuarios(_connection);
            return listUsuarios;
        }

        public static void Data_CrearUsuario(Usuario usuario, string _connection)
        {
            UsuarioData.CrearUsuario(usuario, _connection);
        }
        public static void Data_ModificarUsuario(Usuario usuario, string _connection)
        {
            UsuarioData.ModificarUsuario(usuario, _connection);
        }
        public static void Data_EliminarUsuario(Usuario usuario, string _connection)
        {
            UsuarioData.EliminarUsuario(usuario, _connection);

        }
        #endregion
    }
}
