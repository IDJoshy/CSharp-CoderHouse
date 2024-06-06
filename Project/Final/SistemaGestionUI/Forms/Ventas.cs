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
    public partial class Ventas : Form
    {
        #region Visuals
        public Color gradientTopLeftColor = Color.FromArgb(27, 231, 220);
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

        public Ventas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Gradient2D(this.ClientRectangle, gradientTopLeftColor, gradientBottomLeftColor, gradientTopRightColor, gradientBottomRightColor);

            GetVentas();
        }

        void GetVentas()
        {
            pVenta.Visible = false;
            btnEjecutar.Visible = false;
            lblCurrentCommand.Text = string.Empty;
            lblIDEspecifico.Visible = false;
            tbIDEspecifico.Visible = false;
            cbCommands.SelectedItem = 0;
            cbCommands.Text = "-Seleccionar Comando-";

            try
            {
                List<Venta> venta = VentaBussiness.Bussiness_ListarVentas();
                dgvVentas.DataSource = venta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esto traerá nuevamente a todos las ventas, ¿continuar?.", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GetVentas();
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
                    case "Obtener Venta":
                        List<Venta> venta = VentaBussiness.Bussiness_ObtenerVenta(_id);
                        dgvVentas.DataSource = venta;
                        break;

                    case "Crear Venta":

                        if (MessageBox.Show("Esta acción añadirá al nueva venta a la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Venta ventaNueva = new Venta
                            {
                                Comentarios = tbComentarios.Text,
                                IdUsuario = Convert.ToInt32(tbIdUsuarioVenta.Text)
                            };
                            VentaBussiness.Bussiness_CrearVenta(ventaNueva);
                            MessageBox.Show("Venta Correctamente Creada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Venta No Creada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetVentas();
                        break;

                    case "Modificar Venta":

                        if (MessageBox.Show("Esta acción modificará la venta en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Venta ventaModificada = new Venta
                            {
                                Id = _id,
                                Comentarios = tbComentarios.Text,
                                IdUsuario = Convert.ToInt32(tbIdUsuarioVenta.Text)
                            };
                            VentaBussiness.Bussiness_ModificarVenta(ventaModificada);
                            MessageBox.Show("Venta Correctamente Modificada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Venta No Modificado", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetVentas();
                        break;

                    case "Eliminar Venta":

                        if (MessageBox.Show("Esta acción eliminará el registro de Venta en la data base, ¿desea continuar?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Venta ventaAEliminar = new Venta { Id = _id };
                            VentaBussiness.Bussiness_EliminarVenta(ventaAEliminar);
                            MessageBox.Show("Venta Correctamente Eliminada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Venta No Eliminada", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        GetVentas();
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
            pVenta.Visible = false;

            tbComentarios.ReadOnly = false;
            tbIdUsuarioVenta.ReadOnly = false;

            tbComentarios.Text = String.Empty;
            tbIdUsuarioVenta.Text = String.Empty;

            tbIDEspecifico.ReadOnly = false;
            tbIDEspecifico.Visible = false;
            tbIDEspecifico.Text = String.Empty;
            lblIDEspecifico.Visible = false;

            string current = cbCommands.SelectedItem.ToString();
            lblCurrentCommand.Text = $"Current Command: {current}";


            switch (current)
            {
                case "Obtener Venta":
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Crear Venta":
                    pVenta.Visible = true;
                    break;
                case "Modificar Venta":
                    pVenta.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;
                    break;
                case "Eliminar Venta":
                    pVenta.Visible = true;
                    tbIDEspecifico.Visible = true;
                    lblIDEspecifico.Visible = true;

                    tbComentarios.ReadOnly = true;
                    tbIdUsuarioVenta.ReadOnly = true;

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

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbCommands.SelectedItem.ToString()))
                {
                    if (dgvVentas.SelectedRows.Count > 0)
                    {
                        var selectedRow = dgvVentas.SelectedRows[0];
                        tbIDEspecifico.Text = selectedRow.Cells["Id"].Value.ToString();
                        tbIDEspecifico.ReadOnly = true;
                        string current = cbCommands.SelectedItem.ToString();

                        switch (current)
                        {
                            case "Modificar Venta":
                            case "Eliminar Venta":
                                tbComentarios.Text = selectedRow.Cells["Comentarios"].Value.ToString();
                                tbIdUsuarioVenta.Text = selectedRow.Cells["IdUsuario"].Value.ToString();
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
