namespace SistemaGestionUI.Forms
{
    partial class Ventas
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
            lblCurrentCommand = new Label();
            btnEjecutar = new Design.CustomButton();
            lblComandos = new Label();
            cbCommands = new ComboBox();
            tbIDEspecifico = new TextBox();
            lblIDEspecifico = new Label();
            pVenta = new Design.CustomPanel();
            tbIdUsuarioVenta = new TextBox();
            lblIdUsuarioVenta = new Label();
            tbComentarios = new TextBox();
            lbComentarios = new Label();
            dgvVentas = new DataGridView();
            lblVentas = new Label();
            btnRefresh = new Design.CustomButton();
            pVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentCommand
            // 
            lblCurrentCommand.AutoSize = true;
            lblCurrentCommand.BackColor = Color.Transparent;
            lblCurrentCommand.Location = new Point(10, 235);
            lblCurrentCommand.Name = "lblCurrentCommand";
            lblCurrentCommand.Size = new Size(107, 12);
            lblCurrentCommand.TabIndex = 31;
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
            btnEjecutar.TabIndex = 30;
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
            lblComandos.TabIndex = 29;
            lblComandos.Text = "- Comandos";
            // 
            // cbCommands
            // 
            cbCommands.BackColor = Color.WhiteSmoke;
            cbCommands.Cursor = Cursors.Hand;
            cbCommands.FlatStyle = FlatStyle.Flat;
            cbCommands.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbCommands.FormattingEnabled = true;
            cbCommands.Items.AddRange(new object[] { "-Seleccionar Comando-", "Obtener Venta", "Crear Venta", "Modificar Venta", "Eliminar Venta" });
            cbCommands.Location = new Point(30, 100);
            cbCommands.Name = "cbCommands";
            cbCommands.Size = new Size(196, 21);
            cbCommands.TabIndex = 28;
            cbCommands.Text = "-Seleccionar Comando-";
            cbCommands.SelectedIndexChanged += cbCommands_SelectedIndexChanged;
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
            tbIDEspecifico.TabIndex = 27;
            tbIDEspecifico.TextChanged += tbIDEspecifico_TextChanged;
            // 
            // lblIDEspecifico
            // 
            lblIDEspecifico.AutoSize = true;
            lblIDEspecifico.BackColor = Color.Transparent;
            lblIDEspecifico.Location = new Point(325, 235);
            lblIDEspecifico.Name = "lblIDEspecifico";
            lblIDEspecifico.Size = new Size(101, 12);
            lblIDEspecifico.TabIndex = 26;
            lblIDEspecifico.Text = "> ID Especifico:";
            lblIDEspecifico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pVenta
            // 
            pVenta.ApplyBorder = true;
            pVenta.BackColor = Color.Transparent;
            pVenta.BackgroundImageLayout = ImageLayout.None;
            pVenta.BorderRadius = 20;
            pVenta.ColorBottom = Color.Pink;
            pVenta.ColorTop = Color.Wheat;
            pVenta.Controls.Add(tbIdUsuarioVenta);
            pVenta.Controls.Add(lblIdUsuarioVenta);
            pVenta.Controls.Add(tbComentarios);
            pVenta.Controls.Add(lbComentarios);
            pVenta.ForeColor = Color.Transparent;
            pVenta.Location = new Point(282, 69);
            pVenta.Name = "pVenta";
            pVenta.Padding = new Padding(15);
            pVenta.Size = new Size(405, 94);
            pVenta.TabIndex = 24;
            pVenta.Visible = false;
            // 
            // tbIdUsuarioVenta
            // 
            tbIdUsuarioVenta.BackColor = Color.WhiteSmoke;
            tbIdUsuarioVenta.BorderStyle = BorderStyle.FixedSingle;
            tbIdUsuarioVenta.Location = new Point(184, 57);
            tbIdUsuarioVenta.MaxLength = 24;
            tbIdUsuarioVenta.Name = "tbIdUsuarioVenta";
            tbIdUsuarioVenta.PlaceholderText = "Ingresa ID Usuario";
            tbIdUsuarioVenta.Size = new Size(212, 23);
            tbIdUsuarioVenta.TabIndex = 10;
            // 
            // lblIdUsuarioVenta
            // 
            lblIdUsuarioVenta.AutoSize = true;
            lblIdUsuarioVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdUsuarioVenta.ForeColor = Color.SlateBlue;
            lblIdUsuarioVenta.Location = new Point(18, 58);
            lblIdUsuarioVenta.Name = "lblIdUsuarioVenta";
            lblIdUsuarioVenta.Size = new Size(159, 15);
            lblIdUsuarioVenta.TabIndex = 9;
            lblIdUsuarioVenta.Text = "- ID Usuario Venta:";
            // 
            // tbComentarios
            // 
            tbComentarios.BackColor = Color.WhiteSmoke;
            tbComentarios.BorderStyle = BorderStyle.FixedSingle;
            tbComentarios.Location = new Point(184, 18);
            tbComentarios.MaxLength = 24;
            tbComentarios.Name = "tbComentarios";
            tbComentarios.PlaceholderText = "Ingresa Comentarios";
            tbComentarios.Size = new Size(212, 23);
            tbComentarios.TabIndex = 5;
            // 
            // lbComentarios
            // 
            lbComentarios.AutoSize = true;
            lbComentarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbComentarios.ForeColor = Color.SlateBlue;
            lbComentarios.Location = new Point(18, 19);
            lbComentarios.Name = "lbComentarios";
            lbComentarios.Size = new Size(119, 15);
            lbComentarios.TabIndex = 0;
            lbComentarios.Text = "- Comentarios:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.Dock = DockStyle.Bottom;
            dgvVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentas.Location = new Point(10, 257);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.Size = new Size(680, 270);
            dgvVentas.TabIndex = 23;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.Transparent;
            lblVentas.Font = new Font("Terminus (TTF) for Windows", 15F, FontStyle.Bold);
            lblVentas.ImageAlign = ContentAlignment.MiddleRight;
            lblVentas.Location = new Point(13, 25);
            lblVentas.Name = "lblVentas";
            lblVentas.RightToLeft = RightToLeft.No;
            lblVentas.Size = new Size(90, 21);
            lblVentas.TabIndex = 22;
            lblVentas.Text = "> Ventas";
            lblVentas.TextAlign = ContentAlignment.MiddleLeft;
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
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            btnRefresh.TextColor = Color.WhiteSmoke;
            btnRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Ventas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 537);
            ControlBox = false;
            Controls.Add(lblCurrentCommand);
            Controls.Add(btnEjecutar);
            Controls.Add(lblComandos);
            Controls.Add(cbCommands);
            Controls.Add(tbIDEspecifico);
            Controls.Add(lblIDEspecifico);
            Controls.Add(pVenta);
            Controls.Add(dgvVentas);
            Controls.Add(lblVentas);
            Controls.Add(btnRefresh);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ventas";
            Padding = new Padding(10, 25, 10, 10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Ventas";
            Load += Ventas_Load;
            pVenta.ResumeLayout(false);
            pVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentCommand;
        private Design.CustomButton btnEjecutar;
        private Label lblComandos;
        private ComboBox cbCommands;
        private TextBox tbIDEspecifico;
        private Label lblIDEspecifico;
        private Design.CustomPanel pVenta;
        private TextBox tbIdUsuarioVenta;
        private Label lblIdUsuarioVenta;
        private TextBox tbComentarios;
        private Label lbComentarios;
        private DataGridView dgvVentas;
        private Label lblVentas;
        private Design.CustomButton btnRefresh;
    }
}