namespace SistemaGestionUI.Forms
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblCosto = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblProductos = new Label();
            dgvProductos = new DataGridView();
            pProducto = new Design.CustomPanel();
            tbIdUsuario = new TextBox();
            lblIdUsuario = new Label();
            tbStock = new TextBox();
            tbPrecio = new TextBox();
            tbCosto = new TextBox();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnRefresh = new Design.CustomButton();
            lblIDEspecifico = new Label();
            tbIDEspecifico = new TextBox();
            lblCurrentCommand = new Label();
            btnEjecutar = new Design.CustomButton();
            lblComandos = new Label();
            cbCommands = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pProducto.SuspendLayout();
            SuspendLayout();
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCosto.ForeColor = Color.SlateBlue;
            lblCosto.Location = new Point(18, 43);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(71, 15);
            lblCosto.TabIndex = 1;
            lblCosto.Text = "- Costo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.SlateBlue;
            lblPrecio.Location = new Point(18, 72);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "- Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStock.ForeColor = Color.SlateBlue;
            lblStock.Location = new Point(18, 101);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(71, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "- Stock:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = Color.Transparent;
            lblProductos.Font = new Font("Terminus (TTF) for Windows", 15F, FontStyle.Bold);
            lblProductos.ImageAlign = ContentAlignment.MiddleRight;
            lblProductos.Location = new Point(13, 25);
            lblProductos.Name = "lblProductos";
            lblProductos.RightToLeft = RightToLeft.No;
            lblProductos.Size = new Size(120, 21);
            lblProductos.TabIndex = 1;
            lblProductos.Text = "> Productos";
            lblProductos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Dock = DockStyle.Bottom;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.Location = new Point(10, 257);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.Size = new Size(680, 270);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // pProducto
            // 
            pProducto.ApplyBorder = true;
            pProducto.BackColor = Color.Transparent;
            pProducto.BackgroundImageLayout = ImageLayout.None;
            pProducto.BorderRadius = 20;
            pProducto.ColorBottom = Color.Pink;
            pProducto.ColorTop = Color.Wheat;
            pProducto.Controls.Add(tbIdUsuario);
            pProducto.Controls.Add(lblIdUsuario);
            pProducto.Controls.Add(tbStock);
            pProducto.Controls.Add(tbPrecio);
            pProducto.Controls.Add(tbCosto);
            pProducto.Controls.Add(tbDescripcion);
            pProducto.Controls.Add(lblStock);
            pProducto.Controls.Add(lblPrecio);
            pProducto.Controls.Add(lblCosto);
            pProducto.Controls.Add(lblDescripcion);
            pProducto.ForeColor = Color.Transparent;
            pProducto.Location = new Point(312, 25);
            pProducto.Name = "pProducto";
            pProducto.Padding = new Padding(15);
            pProducto.Size = new Size(375, 162);
            pProducto.TabIndex = 4;
            pProducto.Visible = false;
            // 
            // tbIdUsuario
            // 
            tbIdUsuario.BackColor = Color.WhiteSmoke;
            tbIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbIdUsuario.Location = new Point(145, 129);
            tbIdUsuario.MaxLength = 24;
            tbIdUsuario.Name = "tbIdUsuario";
            tbIdUsuario.PlaceholderText = "Ingresa ID Usuario";
            tbIdUsuario.Size = new Size(212, 23);
            tbIdUsuario.TabIndex = 10;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdUsuario.ForeColor = Color.SlateBlue;
            lblIdUsuario.Location = new Point(18, 130);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(103, 15);
            lblIdUsuario.TabIndex = 9;
            lblIdUsuario.Text = "- IdUsuario:";
            // 
            // tbStock
            // 
            tbStock.BackColor = Color.WhiteSmoke;
            tbStock.BorderStyle = BorderStyle.FixedSingle;
            tbStock.Location = new Point(145, 100);
            tbStock.MaxLength = 24;
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Ingresa Stock";
            tbStock.Size = new Size(212, 23);
            tbStock.TabIndex = 8;
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = Color.WhiteSmoke;
            tbPrecio.BorderStyle = BorderStyle.FixedSingle;
            tbPrecio.Location = new Point(145, 71);
            tbPrecio.MaxLength = 24;
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PlaceholderText = "Ingresa Precio";
            tbPrecio.Size = new Size(212, 23);
            tbPrecio.TabIndex = 7;
            // 
            // tbCosto
            // 
            tbCosto.BackColor = Color.WhiteSmoke;
            tbCosto.BorderStyle = BorderStyle.FixedSingle;
            tbCosto.Location = new Point(145, 42);
            tbCosto.MaxLength = 24;
            tbCosto.Name = "tbCosto";
            tbCosto.PlaceholderText = "Ingresa Costo";
            tbCosto.Size = new Size(212, 23);
            tbCosto.TabIndex = 6;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.WhiteSmoke;
            tbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcion.Location = new Point(145, 13);
            tbDescripcion.MaxLength = 24;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.PlaceholderText = "Ingresa Descripción";
            tbDescripcion.Size = new Size(212, 23);
            tbDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.SlateBlue;
            lblDescripcion.Location = new Point(18, 15);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(119, 15);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "- Descripcion:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.MediumSlateBlue;
            btnRefresh.BackGroundColor = Color.MediumSlateBlue;
            btnRefresh.BorderColor = Color.PaleVioletRed;
            btnRefresh.BorderRadius = 25;
            btnRefresh.BorderSize = 0;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.WhiteSmoke;
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleRight;
            btnRefresh.Location = new Point(608, 210);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(79, 41);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.TextColor = Color.WhiteSmoke;
            btnRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblIDEspecifico
            // 
            lblIDEspecifico.AutoSize = true;
            lblIDEspecifico.BackColor = Color.Transparent;
            lblIDEspecifico.Location = new Point(325, 235);
            lblIDEspecifico.Name = "lblIDEspecifico";
            lblIDEspecifico.Size = new Size(101, 12);
            lblIDEspecifico.TabIndex = 9;
            lblIDEspecifico.Text = "> ID Especifico:";
            lblIDEspecifico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbIDEspecifico
            // 
            tbIDEspecifico.BackColor = Color.WhiteSmoke;
            tbIDEspecifico.BorderStyle = BorderStyle.FixedSingle;
            tbIDEspecifico.Location = new Point(432, 228);
            tbIDEspecifico.MaxLength = 24;
            tbIDEspecifico.Name = "tbIDEspecifico";
            tbIDEspecifico.PlaceholderText = "Ingresa ID";
            tbIDEspecifico.Size = new Size(162, 23);
            tbIDEspecifico.TabIndex = 10;
            tbIDEspecifico.TextChanged += tbIDEspecifico_TextChanged;
            // 
            // lblCurrentCommand
            // 
            lblCurrentCommand.AutoSize = true;
            lblCurrentCommand.BackColor = Color.Transparent;
            lblCurrentCommand.Location = new Point(10, 235);
            lblCurrentCommand.Name = "lblCurrentCommand";
            lblCurrentCommand.Size = new Size(107, 12);
            lblCurrentCommand.TabIndex = 21;
            lblCurrentCommand.Text = "Current Command: ";
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.MediumSlateBlue;
            btnEjecutar.BackGroundColor = Color.MediumSlateBlue;
            btnEjecutar.BorderColor = Color.PaleVioletRed;
            btnEjecutar.BorderRadius = 40;
            btnEjecutar.BorderSize = 0;
            btnEjecutar.FlatAppearance.BorderSize = 0;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.ForeColor = Color.WhiteSmoke;
            btnEjecutar.Location = new Point(140, 130);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(94, 40);
            btnEjecutar.TabIndex = 20;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.TextColor = Color.WhiteSmoke;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblComandos
            // 
            lblComandos.AutoSize = true;
            lblComandos.BackColor = Color.Transparent;
            lblComandos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComandos.Location = new Point(30, 70);
            lblComandos.Name = "lblComandos";
            lblComandos.Size = new Size(87, 15);
            lblComandos.TabIndex = 19;
            lblComandos.Text = "- Comandos";
            // 
            // cbCommands
            // 
            cbCommands.BackColor = Color.WhiteSmoke;
            cbCommands.Cursor = Cursors.Hand;
            cbCommands.FlatStyle = FlatStyle.Flat;
            cbCommands.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbCommands.FormattingEnabled = true;
            cbCommands.Items.AddRange(new object[] { "-Seleccionar Comando-", "Obtener Producto", "Crear Producto", "Modificar Producto", "Eliminar Producto" });
            cbCommands.Location = new Point(30, 100);
            cbCommands.Name = "cbCommands";
            cbCommands.Size = new Size(196, 21);
            cbCommands.TabIndex = 18;
            cbCommands.Text = "-Seleccionar Comando-";
            cbCommands.SelectedIndexChanged += cbCommands_SelectedIndexChanged;
            // 
            // Productos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 537);
            ControlBox = false;
            Controls.Add(lblCurrentCommand);
            Controls.Add(btnEjecutar);
            Controls.Add(lblComandos);
            Controls.Add(cbCommands);
            Controls.Add(tbIDEspecifico);
            Controls.Add(lblIDEspecifico);
            Controls.Add(btnRefresh);
            Controls.Add(pProducto);
            Controls.Add(dgvProductos);
            Controls.Add(lblProductos);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Productos";
            Padding = new Padding(10, 25, 10, 10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pProducto.ResumeLayout(false);
            pProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductos;
        private DataGridView dgvProductos;
        private Design.CustomPanel pProducto;
        private Label lblDescripcion;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblCosto;
        private Design.CustomButton btnRefresh;
        private TextBox tbDescripcion;
        private TextBox tbPrecio;
        private TextBox tbCosto;
        private TextBox tbStock;
        private Label lblIDEspecifico;
        private TextBox tbIDEspecifico;
        private Label lblCurrentCommand;
        private Design.CustomButton btnEjecutar;
        private Label lblComandos;
        private ComboBox cbCommands;
        private TextBox tbIdUsuario;
        private Label lblIdUsuario;
    }
}