using Microsoft.VisualBasic.ApplicationServices;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.Forms
{
    public partial class Productos : Form
    {
        #region Visuals
        public Color gradientTopLeftColor = Color.FromArgb(255, 205, 85);
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

        public Productos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Gradient2D(this.ClientRectangle, gradientTopLeftColor, gradientBottomLeftColor, gradientTopRightColor, gradientBottomRightColor);
            GetProductos();
        }

        void GetProductos()
        {
            pProducto.Visible = false;
            btnEjecutar.Visible = false;
            lblCurrentCommand.Text = string.Empty;
            lblIDEspecifico.Visible = false;
            tbIDEspecifico.Visible = false;
            cbCommands.SelectedItem = 0;
            cbCommands.Text = "-Seleccionar Comando-";

            try
            {
                List<Producto> producto = ProductoBussiness.Bussiness_ListarProductos();
                dgvProductos.DataSource = producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esto traerá nuevamente a todos los productos, ¿continuar?.", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GetProductos();
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
                    case "Obtener Producto":
                        List<Producto> producto = ProductoBussiness.Bussiness_ObtenerProducto(_id);
                        dgvProductos.DataSource = producto;
                        break;

                    case "Crear Producto":

                        if (MessageBox.Show("Esta acción añadirá al nuevo producto de la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Producto productoNuevo = new Producto
                            {
                                Descripcion = tbDescripcion.Text,
                                Costo = Convert.ToDouble(tbCosto.Text),
                                PrecioVenta = Convert.ToDouble(tbPrecio.Text),
                                Stock = Convert.ToInt32(tbStock.Text),
                                IdUsuario = Convert.ToInt32(tbIdUsuario.Text)
                            };
                            ProductoBussiness.Bussiness_CrearProducto(productoNuevo);
                            MessageBox.Show("Producto Correctamente Creado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto No Creado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductos();
                        break;

                    case "Modificar Producto":

                        if (MessageBox.Show("Esta acción modificará el producto en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Producto productoModificado = new Producto
                            {
                                Id = _id,
                                Descripcion = tbDescripcion.Text,
                                Costo = Convert.ToDouble(tbCosto.Text),
                                PrecioVenta = Convert.ToDouble(tbPrecio.Text),
                                Stock = Convert.ToInt32(tbStock.Text),
                                IdUsuario = Convert.ToInt32(tbIdUsuario.Text)
                            };
                            ProductoBussiness.Bussiness_ModificarProducto(productoModificado);
                            MessageBox.Show("Producto Correctamente Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto No Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductos();
                        break;

                    case "Eliminar Producto":

                        if (MessageBox.Show("Esta acción eliminará el producto en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Producto productoAEliminar = new Producto { Id = _id };
                            ProductoBussiness.Bussiness_EliminarProducto(productoAEliminar);
                            MessageBox.Show("Producto Correctamente Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto No Eliminado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetProductos();
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
            pProducto.Visible = false;

            tbDescripcion.ReadOnly = false;
            tbCosto.ReadOnly = false;
            tbPrecio.ReadOnly = false;
            tbStock.ReadOnly = false;
            tbIdUsuario.ReadOnly = false;

            tbDescripcion.Text = String.Empty;
            tbCosto.Text = String.Empty;
            tbPrecio.Text = String.Empty;
            tbStock.Text = String.Empty;
            tbIdUsuario.Text = String.Empty;

            tbIDEspecifico.ReadOnly = false;
            tbIDEspecifico.Visible = false;
            tbIDEspecifico.Text = String.Empty;
            lblIDEspecifico.Visible = false;

            string current = cbCommands.SelectedItem.ToString();
            lblCurrentCommand.Text = $"Current Command: {current}";


            switch (current)
            {
                case "Obtener Producto":
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Crear Producto":
                    pProducto.Visible = true;
                    break;
                case "Modificar Producto":
                    pProducto.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Eliminar Producto":
                    pProducto.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;

                    tbDescripcion.ReadOnly = true;
                    tbCosto.ReadOnly = true;
                    tbPrecio.ReadOnly = true;
                    tbStock.ReadOnly = true;
                    tbIdUsuario.ReadOnly = true;
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbCommands.SelectedItem.ToString()))
                {
                    if (dgvProductos.SelectedRows.Count > 0)
                    {
                        var selectedRow = dgvProductos.SelectedRows[0];
                        tbIDEspecifico.Text = selectedRow.Cells["Id"].Value.ToString();
                        tbIDEspecifico.ReadOnly = true;
                        string current = cbCommands.SelectedItem.ToString();

                        switch (current)
                        {
                            case "Modificar Producto":
                            case "Eliminar Producto":
                                tbDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                                tbCosto.Text = selectedRow.Cells["Costo"].Value.ToString();
                                tbPrecio.Text = selectedRow.Cells["PrecioVenta"].Value.ToString();
                                tbStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                                tbIdUsuario.Text = selectedRow.Cells["IdUsuario"].Value.ToString();
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

        private void tbIDEspecifico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
