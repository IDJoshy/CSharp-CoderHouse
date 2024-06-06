using Desktop.DB;
using Desktop.Models;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MainWindow : Form
    {
        public float borderRadius { get; set; } = 30f;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Gradient2D(this.ClientRectangle, gradientTopLeftColor, gradientBottomLeftColor, gradientTopRightColor, gradientBottomRightColor);
            PanelsHide();
        }

        #region Visuals

        public Color gradientTopLeftColor = Color.FromArgb(95, 51, 184);
        public Color gradientBottomLeftColor = Color.FromArgb(98, 41, 214);
        public Color gradientTopRightColor = Color.FromArgb(77, 33, 173);
        public Color gradientBottomRightColor = Color.FromArgb(43, 24, 82);

        Bitmap Gradient2D(Rectangle r, Color c1, Color c2, Color c3, Color c4)
        {
            Bitmap bmp = new Bitmap(r.Width, r.Height);

            float delta12R = 1f * (c2.R - c1.R) / r.Height;
            float delta12G = 1f * (c2.G - c1.G) / r.Height;
            float delta12B = 1f * (c2.B - c1.B) / r.Height;
            float delta34R = 1f * (c4.R - c3.R) / r.Height;
            float delta34G = 1f * (c4.G - c3.G) / r.Height;
            float delta34B = 1f * (c4.B - c3.B) / r.Height;
            using (Graphics G = Graphics.FromImage(bmp))
                for (int y = 0; y < r.Height; y++)
                {
                    Color c12 = Color.FromArgb(255, c1.R + (int)(y * delta12R),
                          c1.G + (int)(y * delta12G), c1.B + (int)(y * delta12B));
                    Color c34 = Color.FromArgb(255, c3.R + (int)(y * delta34R),
                          c3.G + (int)(y * delta34G), c3.B + (int)(y * delta34B));
                    using (LinearGradientBrush lgBrush = new LinearGradientBrush(
                          new Rectangle(0, y, r.Width, 1), c12, c34, 0f))
                    { G.FillRectangle(lgBrush, 0, y, r.Width, 1); }
                }
            return bmp;
        }

        #endregion

        private void bMainWindowExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        void PanelsHide()
        {
            pUsuario.Visible = false;
            pProducto.Visible = false;
            pProductoVendido.Visible = false;
            pVenta.Visible = false;
            lblCurrentCommand.Text = "";
        }

        private void cbComandos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelsHide();
            string? currentCommand = cbComandos.SelectedItem.ToString();
            lblCurrentCommand.Text = $"Current Command: {currentCommand}";
            switch (currentCommand)
            {
                case "Crear Usuario":
                case "Modificar Usuario":
                    pUsuario.Visible = true;
                    break;

                case "Crear Producto":
                case "Modificar Producto":
                    pProducto.Visible = true;
                    break;

                case "Crear Producto Vendido":
                case "Modificar Producto Vendido":
                    pProductoVendido.Visible = true;
                    break;
                case "Crear Venta":
                case "Modificar Venta":
                    pVenta.Visible = true;
                    break;
            }
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string? currentCommand = cbComandos.SelectedItem.ToString();
                string? specificID = tbIdEspecifico.Text;
                int _id = 0; // Siempre se elige el id 0 si no es especificado

                if (currentCommand.Contains("Obtener") || currentCommand.Contains("Modificar") || currentCommand.Contains("Eliminar"))
                {
                    if (!int.TryParse(specificID, out _id))
                    {
                        MessageBox.Show("Ingrese un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                    }

                }

                /*
                 Obtener Usuario
                Listar Usuarios
                Crear Usuario
                Modificar Usuario
                Eliminar Usuario
                Obtener Producto
                Listar Productos
                Crear Producto
                Modificar Producto
                Eliminar Producto
                Obtener Producto Vendido
                Listar Productos Vendidos
                Crear Producto Vendido
                Modificar Producto Vendido
                Eliminar Producto Vendido
                Obtener Venta
                Listar Ventas
                Crear Venta
                Modificar Venta
                Eliminar Venta
                */

                switch (currentCommand)
                {
                    case "Obtener Usuario":
                        List<Usuario> usuarios = UsuarioData.ObtenerUsuario(_id);
                        dgvData.DataSource = usuarios;
                        break;
                    case "Listar Usuarios":
                        List<Usuario> listUsuarios = UsuarioData.ListarUsuarios();
                        dgvData.DataSource = listUsuarios;
                        break;
                    case "Crear Usuario":
                        Usuario usuarioNuevo = new Usuario
                        {
                            Nombre = tbNombre.Text,
                            Apellido = tbApellido.Text,
                            NombreUsuario = tbNombreUsuario.Text,
                            Contrasenia = tbContra.Text,
                            Mail = tbEmail.Text,
                        };
                        UsuarioData.CrearUsuario(usuarioNuevo);
                        MessageBox.Show("Usuario Correctamente Creado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(0);
                        break;
                    case "Modificar Usuario":
                        Usuario usuarioModificado = new Usuario
                        {
                            Id = _id,
                            Nombre = tbNombre.Text,
                            Apellido = tbApellido.Text,
                            NombreUsuario = tbNombreUsuario.Text,
                            Contrasenia = tbContra.Text,
                            Mail = tbEmail.Text,
                        };
                        UsuarioData.ModificarUsuario(usuarioModificado);
                        MessageBox.Show("Usuario Correctamente Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(0);
                        break;
                    case "Eliminar Usuario":
                        Usuario usuarioAEliminar = new Usuario { Id = _id};
                        UsuarioData.EliminarUsuario(usuarioAEliminar);
                        MessageBox.Show("Usuario Correctamente Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(0);
                        break;


                    case "Obtener Producto":
                        List<Producto> producto = ProductoData.ObtenerProducto(_id);
                        dgvData.DataSource = producto;
                        break;
                    case "Listar Productos":
                        List<Producto> listProductos = ProductoData.ListarProductos();
                        dgvData.DataSource = listProductos;
                        break;
                    case "Crear Producto":
                        Producto productoNuevo = new Producto 
                        {
                            Descripcion = tbDescripcion.Text,
                            Costo = Convert.ToDouble(tbCosto.Text),
                            PrecioVenta = Convert.ToDouble(tbPrecioVenta.Text),
                            Stock = Convert.ToInt32(tbStock.Text),
                            IdUsuario = Convert.ToInt32(tbIdUsuario.Text)
                        };
                        ProductoData.CrearProducto(productoNuevo);
                        MessageBox.Show("Producto Correctamente A�adido", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(1);
                        break;
                    case "Modificar Producto":
                        Producto productoModificado = new Producto
                        {
                            Id = _id,
                            Descripcion = tbDescripcion.Text,
                            Costo = Convert.ToDouble(tbCosto.Text),
                            PrecioVenta = Convert.ToDouble(tbPrecioVenta.Text),
                            Stock = Convert.ToInt32(tbStock.Text),
                            IdUsuario = Convert.ToInt32(tbIdUsuario.Text)
                        };
                        ProductoData.ModificarProducto(productoModificado);
                        MessageBox.Show("Producto Correctamente Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(1);
                        break;
                    case "Eliminar Producto":
                        Producto productoAEliminar = new Producto { Id = _id };
                        ProductoData.EliminarProducto(productoAEliminar);
                        MessageBox.Show("Producto Correctamente Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(1);
                        break;


                    case "Obtener Producto Vendido":
                        List<ProductoVendido> productosVendido = ProductoVendidoData.ObtenerProductoVendido(_id);
                        dgvData.DataSource = productosVendido;
                        break;
                    case "Listar Productos Vendidos":
                        List<ProductoVendido> listaProductosVendidos = ProductoVendidoData.ListarProductosVendidos();
                        dgvData.DataSource = listaProductosVendidos;
                        break;
                    case "Crear Producto Vendido":
                        ProductoVendido productoVendidoNuevo = new ProductoVendido
                        {
                            IdProducto = Convert.ToInt32(tbIdProducto.Text),
                            Stock = Convert.ToInt32(tbStockVenta.Text),
                            IdVenta = Convert.ToInt32(tbIdVenta.Text)
                        };
                        ProductoVendidoData.CrearProductoVendido(productoVendidoNuevo);
                        MessageBox.Show("Producto Vendido Correctamente A�adido", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(2);
                        break;
                    case "Modificar Producto Vendido":
                        ProductoVendido productoVendidoModificado = new ProductoVendido
                        {
                            Id = _id,
                            IdProducto = Convert.ToInt32(tbIdProducto.Text),
                            Stock = Convert.ToInt32(tbStockVenta.Text),
                            IdVenta = Convert.ToInt32(tbIdVenta.Text)
                        };
                        ProductoVendidoData.ModificarProductoVendido(productoVendidoModificado);
                        MessageBox.Show("Producto Vendido Correctamente Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(2);
                        break;
                    case "Eliminar Producto Vendido":
                        ProductoVendido productoVendidoAEliminar = new ProductoVendido { Id = _id };
                        ProductoVendidoData.EliminarProductoVendido(productoVendidoAEliminar);
                        MessageBox.Show("Producto Vendido Correctamente Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(2);
                        break;


                    case "Obtener Venta":
                        List<Venta> venta = VentaData.ObtenerVenta(_id);
                        dgvData.DataSource = venta;
                        break;
                    case "Listar Ventas":
                        List<Venta> listVentas = VentaData.ListarVentas();
                        dgvData.DataSource = listVentas;
                        break;
                    case "Crear Venta":
                        Venta ventaNueva = new Venta
                        {
                            Comentarios = tbComentarios.Text,
                            IdUsuario = Convert.ToInt32(tbIdUsuarioVenta.Text)
                        };
                        VentaData.CrearVenta(ventaNueva);
                        MessageBox.Show("Venta Correctamente Creada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(3);
                        break;
                    case "Modificar Venta":
                        Venta ventaModificada = new Venta
                        {
                            Id = _id,
                            Comentarios = tbComentarios.Text,
                            IdUsuario = Convert.ToInt32(tbIdUsuarioVenta.Text)
                        };
                        VentaData.ModificarVenta(ventaModificada);
                        MessageBox.Show("Venta Correctamente Modificada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(3);
                        break;
                    case "Eliminar Venta":
                        Venta ventaAEliminar = new Venta { Id = _id };
                        VentaData.EliminarVenta(ventaAEliminar);
                        MessageBox.Show("Venta Correctamente Eliminada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDGV(3);
                        break;
                    default:
                        MessageBox.Show("No Valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            dgvData.Refresh();
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
           
        }

        private void RefreshDGV(int Index)
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            switch (Index)
            {
                case 0:
                    List<Usuario> listUsuarios = UsuarioData.ListarUsuarios();
                    dgvData.DataSource = listUsuarios;
                    break;
                case 1:
                    List<Producto> listProductos = ProductoData.ListarProductos();
                    dgvData.DataSource = listProductos;
                    break;
                case 2:
                    List<ProductoVendido> listaProductosVendidos = ProductoVendidoData.ListarProductosVendidos();
                    dgvData.DataSource = listaProductosVendidos;
                    break;
                case 3:
                    List<Venta> listVentas = VentaData.ListarVentas();
                    dgvData.DataSource = listVentas;
                    break;

                default:
                    MessageBox.Show("No hay lista que refrescar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
