namespace SistemaGestionUI.Forms
{
    partial class ProductosVendidos
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
            lblStock = new Label();
            lblProductosVenta = new Label();
            dgvProductosVendidos = new DataGridView();
            pProductosVendidos = new Design.CustomPanel();
            tbIdVenta = new TextBox();
            lblIdVenta = new Label();
            tbStock = new TextBox();
            tbIdProducto = new TextBox();
            lbldProducto = new Label();
            btnRefresh = new Design.CustomButton();
            lblIDEspecifico = new Label();
            tbIDEspecifico = new TextBox();
            lblCurrentCommand = new Label();
            btnEjecutar = new Design.CustomButton();
            lblComandos = new Label();
            cbCommands = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVendidos).BeginInit();
            pProductosVendidos.SuspendLayout();
            SuspendLayout();
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStock.ForeColor = Color.SlateBlue;
            lblStock.Location = new Point(18, 43);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(71, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "- Stock:";
            // 
            // lblProductosVenta
            // 
            lblProductosVenta.AutoSize = true;
            lblProductosVenta.BackColor = Color.Transparent;
            lblProductosVenta.Font = new Font("Terminus (TTF) for Windows", 15F, FontStyle.Bold);
            lblProductosVenta.ImageAlign = ContentAlignment.MiddleRight;
            lblProductosVenta.Location = new Point(13, 25);
            lblProductosVenta.Name = "lblProductosVenta";
            lblProductosVenta.RightToLeft = RightToLeft.No;
            lblProductosVenta.Size = new Size(210, 21);
            lblProductosVenta.TabIndex = 1;
            lblProductosVenta.Text = "> Productos Vendidos";
            lblProductosVenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProductosVendidos
            // 
            dgvProductosVendidos.AllowUserToAddRows = false;
            dgvProductosVendidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dgvProductosVendidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductosVendidos.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvProductosVendidos.BorderStyle = BorderStyle.None;
            dgvProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductosVendidos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductosVendidos.Dock = DockStyle.Bottom;
            dgvProductosVendidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductosVendidos.Location = new Point(10, 257);
            dgvProductosVendidos.Name = "dgvProductosVendidos";
            dgvProductosVendidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductosVendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvProductosVendidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductosVendidos.Size = new Size(680, 270);
            dgvProductosVendidos.TabIndex = 2;
            dgvProductosVendidos.CellClick += dgvProductosVendidos_CellClick;
            // 
            // pProductosVendidos
            // 
            pProductosVendidos.ApplyBorder = true;
            pProductosVendidos.BackColor = Color.Transparent;
            pProductosVendidos.BackgroundImageLayout = ImageLayout.None;
            pProductosVendidos.BorderRadius = 20;
            pProductosVendidos.ColorBottom = Color.Pink;
            pProductosVendidos.ColorTop = Color.Wheat;
            pProductosVendidos.Controls.Add(tbIdVenta);
            pProductosVendidos.Controls.Add(lblIdVenta);
            pProductosVendidos.Controls.Add(tbStock);
            pProductosVendidos.Controls.Add(tbIdProducto);
            pProductosVendidos.Controls.Add(lblStock);
            pProductosVendidos.Controls.Add(lbldProducto);
            pProductosVendidos.ForeColor = Color.Transparent;
            pProductosVendidos.Location = new Point(312, 25);
            pProductosVendidos.Name = "pProductosVendidos";
            pProductosVendidos.Padding = new Padding(15);
            pProductosVendidos.Size = new Size(375, 108);
            pProductosVendidos.TabIndex = 4;
            pProductosVendidos.Visible = false;
            // 
            // tbIdVenta
            // 
            tbIdVenta.BackColor = Color.WhiteSmoke;
            tbIdVenta.BorderStyle = BorderStyle.FixedSingle;
            tbIdVenta.Location = new Point(145, 71);
            tbIdVenta.MaxLength = 24;
            tbIdVenta.Name = "tbIdVenta";
            tbIdVenta.PlaceholderText = "Ingresa ID Venta";
            tbIdVenta.Size = new Size(212, 23);
            tbIdVenta.TabIndex = 10;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdVenta.ForeColor = Color.SlateBlue;
            lblIdVenta.Location = new Point(18, 72);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(95, 15);
            lblIdVenta.TabIndex = 9;
            lblIdVenta.Text = "- ID Venta:";
            // 
            // tbStock
            // 
            tbStock.BackColor = Color.WhiteSmoke;
            tbStock.BorderStyle = BorderStyle.FixedSingle;
            tbStock.Location = new Point(145, 42);
            tbStock.MaxLength = 24;
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Ingresa Stock";
            tbStock.Size = new Size(212, 23);
            tbStock.TabIndex = 8;
            // 
            // tbIdProducto
            // 
            tbIdProducto.BackColor = Color.WhiteSmoke;
            tbIdProducto.BorderStyle = BorderStyle.FixedSingle;
            tbIdProducto.Location = new Point(145, 13);
            tbIdProducto.MaxLength = 24;
            tbIdProducto.Name = "tbIdProducto";
            tbIdProducto.PlaceholderText = "Ingresa lD Producto";
            tbIdProducto.Size = new Size(212, 23);
            tbIdProducto.TabIndex = 5;
            // 
            // lbldProducto
            // 
            lbldProducto.AutoSize = true;
            lbldProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbldProducto.ForeColor = Color.SlateBlue;
            lbldProducto.Location = new Point(18, 15);
            lbldProducto.Name = "lbldProducto";
            lbldProducto.Size = new Size(119, 15);
            lbldProducto.TabIndex = 0;
            lbldProducto.Text = "- ID Producto:";
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
            cbCommands.Items.AddRange(new object[] { "-Seleccionar Comando-", "Obtener Producto Vendido", "Crear Producto Vendido", "Modificar Producto Vendido", "Eliminar Producto Vendido" });
            cbCommands.Location = new Point(30, 100);
            cbCommands.Name = "cbCommands";
            cbCommands.Size = new Size(196, 21);
            cbCommands.TabIndex = 18;
            cbCommands.Text = "-Seleccionar Comando-";
            cbCommands.SelectedIndexChanged += cbCommands_SelectedIndexChanged;
            // 
            // ProductosVendidos
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
            Controls.Add(pProductosVendidos);
            Controls.Add(dgvProductosVendidos);
            Controls.Add(lblProductosVenta);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductosVendidos";
            Padding = new Padding(10, 25, 10, 10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ProductosVendidos";
            Load += ProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosVendidos).EndInit();
            pProductosVendidos.ResumeLayout(false);
            pProductosVendidos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductosVenta;
        private DataGridView dgvProductosVendidos;
        private Design.CustomPanel pProductosVendidos;
        private Label lbldProducto;
        private Label lblStock;
        private Design.CustomButton btnRefresh;
        private TextBox tbIdProducto;
        private TextBox tbStock;
        private Label lblIDEspecifico;
        private TextBox tbIDEspecifico;
        private Label lblCurrentCommand;
        private Design.CustomButton btnEjecutar;
        private Label lblComandos;
        private ComboBox cbCommands;
        private TextBox tbIdVenta;
        private Label lblIdVenta;
    }
}