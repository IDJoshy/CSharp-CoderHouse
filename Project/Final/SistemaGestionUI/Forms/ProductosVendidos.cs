using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.Forms
{
    public partial class ProductosVendidos : Form
    {
        #region Visuals
        public Color gradientTopLeftColor = Color.FromArgb(251, 195, 141);
        public Color gradientBottomLeftColor = Color.FromArgb(11, 57, 84);
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

        public ProductosVendidos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ProductosVendidos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Gradient2D(this.ClientRectangle, gradientTopLeftColor, gradientBottomLeftColor, gradientTopRightColor, gradientBottomRightColor);
            GetProductosVendidos();
        }

        void GetProductosVendidos()
        {
            pProductosVendidos.Visible = false;
            btnEjecutar.Visible = false;
            lblCurrentCommand.Text = string.Empty;
            lblIDEspecifico.Visible = false;
            tbIDEspecifico.Visible = false;
            cbCommands.SelectedItem = 0;
            cbCommands.Text = "-Seleccionar Comando-";

            try
            {
                List<ProductoVendido> listProductosVendidos = ProductoVendidoBussiness.Bussiness_ListarProductosVendidos();
                dgvProductosVendidos.DataSource = listProductosVendidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esto traerá nuevamente a todos los productos vendidos, ¿continuar?.", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GetProductosVendidos();
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string? current = cbCommands.SelectedItem.ToString();
                string? specificID = tbIDEspecifico.Text;
                int _id = 0;

                if (current.Contains("Obtener") || current.Contains("Modificar") || current.Contains("Eliminar"))
                {
                    if (!int.TryParse(specificID, out _id))
                    {
                        MessageBox.Show("Ingrese un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                switch (current)
                {
                    case "Obtener Producto Vendido":
                        List<ProductoVendido> productoVendido = ProductoVendidoBussiness.Bussiness_ObtenerProductoVendido(_id);
                        dgvProductosVendidos.DataSource = productoVendido;
                        break;

                    case "Crear Producto Vendido":

                        if (MessageBox.Show("Esta acción añadirá al nuevo producto en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            ProductoVendido productoNuevo = new ProductoVendido
                            {
                                IdProducto = Convert.ToInt32(tbIdProducto.Text),
                                Stock = Convert.ToInt32(tbStock.Text),
                                IdVenta = Convert.ToInt32(tbIdVenta.Text)
                            };
                            ProductoVendidoBussiness.Bussiness_CrearProductoVendido(productoNuevo);
                            MessageBox.Show("Producto Vendido Correctamente Creado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto Vendido No Creado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductosVendidos();
                        break;

                    case "Modificar Producto Vendido":

                        if (MessageBox.Show("Esta acción modificará el producto en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            ProductoVendido productoVendidoModificado = new ProductoVendido
                            {
                                Id = _id,
                                IdProducto = Convert.ToInt32(tbIdProducto.Text),
                                Stock = Convert.ToInt32(tbStock.Text),
                                IdVenta = Convert.ToInt32(tbIdVenta.Text)
                            };
                            ProductoVendidoBussiness.Bussiness_ModificarProductoVendido(productoVendidoModificado);
                            MessageBox.Show("Producto Vendido Correctamente Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto No Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductosVendidos();
                        break;

                    case "Eliminar Producto":

                        if (MessageBox.Show("Esta acción eliminará el producto en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            ProductoVendido productoAEliminar = new ProductoVendido { Id = _id };
                            ProductoVendidoBussiness.Bussiness_EliminarProducto(productoAEliminar);
                            MessageBox.Show("Producto Correctamente Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto No Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductosVendidos();
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

        private void cbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            pProductosVendidos.Visible = false;

            tbIdProducto.ReadOnly = false;
            tbStock.ReadOnly = false;
            tbIdVenta.ReadOnly = false;

            tbIdProducto.Text = String.Empty;
            tbStock.Text = String.Empty;
            tbIdVenta.Text = String.Empty;

            tbIDEspecifico.ReadOnly = false;
            tbIDEspecifico.Visible = false;
            tbIDEspecifico.Text = String.Empty;
            lblIDEspecifico.Visible = false;

            string current = cbCommands.SelectedItem.ToString();
            lblCurrentCommand.Text = $"Current Command: {current}";


            switch (current)
            {
                case "Obtener Producto Vendido":
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Crear Producto Vendido":
                    pProductosVendidos.Visible = true;
                    break;
                case "Modificar Producto Vendido":
                    pProductosVendidos.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Eliminar Producto Vendido":
                    pProductosVendidos.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;

                    tbIdProducto.ReadOnly = true;
                    tbStock.ReadOnly = true;
                    tbIdVenta.ReadOnly = true;
                    break;

                default: break;
            }

            if (String.IsNullOrEmpty(current) || current == "-Seleccionar Comando-")
            {
                btnEjecutar.Visible = false;
            }
            else
            {
                btnEjecutar.Visible = true;
            }
        }

        private void dgvProductosVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbCommands.SelectedItem.ToString()))
                {
                    if (dgvProductosVendidos.SelectedRows.Count > 0)
                    {
                        var selectedRow = dgvProductosVendidos.SelectedRows[0];
                        tbIDEspecifico.Text = selectedRow.Cells["Id"].Value.ToString();
                        tbIDEspecifico.ReadOnly = true;
                        string current = cbCommands.SelectedItem.ToString();

                        switch (current)
                        {
                            case "Modificar Producto Vendido":
                            case "Eliminar Producto Vendido":
                                tbIdProducto.Text = selectedRow.Cells["IdProducto"].Value.ToString();
                                tbStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                                tbIdVenta.Text = selectedRow.Cells["IdVenta"].Value.ToString();
                                break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
