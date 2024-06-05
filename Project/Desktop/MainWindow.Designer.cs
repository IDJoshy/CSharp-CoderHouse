namespace Desktop
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblEmail;
            Label lblPassword;
            Label lblUserName;
            Label lblApellido;
            Label lblNombre;
            Label lblIdUsuario;
            Label lblStock;
            Label lblPrecioVenta;
            Label lblCosto;
            Label lblDescripcion;
            Label lblIdProducto;
            Label lblStockVenta;
            Label lblIdVenta;
            Label lblComentarios;
            Label lblIdUsuarioVenta;
            cbComandos = new ComboBox();
            pUsuario = new Design.PanelGradient();
            tbEmail = new TextBox();
            tbContra = new TextBox();
            tbNombreUsuario = new TextBox();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            bMainWindowExit = new Button();
            label1 = new Label();
            dgvData = new DataGridView();
            pProducto = new Design.PanelGradient();
            tbIdUsuario = new TextBox();
            tbStock = new TextBox();
            tbPrecioVenta = new TextBox();
            tbCosto = new TextBox();
            tbDescripcion = new TextBox();
            pProductoVendido = new Design.PanelGradient();
            tbIdVenta = new TextBox();
            tbStockVenta = new TextBox();
            tbIdProducto = new TextBox();
            tbIdEspecifico = new TextBox();
            lblEspecificos = new Label();
            btnRefresh = new Button();
            btnExecute = new Button();
            pVenta = new Design.PanelGradient();
            tbIdUsuarioVenta = new TextBox();
            tbComentarios = new TextBox();
            lblCurrentCommand = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblUserName = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblIdUsuario = new Label();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblDescripcion = new Label();
            lblIdProducto = new Label();
            lblStockVenta = new Label();
            lblIdVenta = new Label();
            lblComentarios = new Label();
            lblIdUsuarioVenta = new Label();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pProducto.SuspendLayout();
            pProductoVendido.SuspendLayout();
            pVenta.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(35, 12);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 12);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(25, 90);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 12);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Nombre Usuario";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 60);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(53, 12);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(41, 12);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(25, 150);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(65, 12);
            lblIdUsuario.TabIndex = 8;
            lblIdUsuario.Text = "ID Usuario";
            lblIdUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(25, 120);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(35, 12);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(25, 90);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(71, 12);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "PrecioVenta";
            lblPrecioVenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(25, 60);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(35, 12);
            lblCosto.TabIndex = 2;
            lblCosto.Text = "Costo";
            lblCosto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(25, 30);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(71, 12);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(25, 30);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(65, 12);
            lblIdProducto.TabIndex = 0;
            lblIdProducto.Text = "IDProducto";
            // 
            // lblStockVenta
            // 
            lblStockVenta.AutoSize = true;
            lblStockVenta.Location = new Point(25, 60);
            lblStockVenta.Name = "lblStockVenta";
            lblStockVenta.Size = new Size(71, 12);
            lblStockVenta.TabIndex = 1;
            lblStockVenta.Text = "Stock Venta";
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(25, 90);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(53, 12);
            lblIdVenta.TabIndex = 2;
            lblIdVenta.Text = "ID Venta";
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.BackColor = Color.Transparent;
            lblComentarios.ForeColor = SystemColors.Desktop;
            lblComentarios.Location = new Point(25, 28);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(71, 12);
            lblComentarios.TabIndex = 1;
            lblComentarios.Text = "Comentarios";
            // 
            // lblIdUsuarioVenta
            // 
            lblIdUsuarioVenta.AutoSize = true;
            lblIdUsuarioVenta.BackColor = Color.Transparent;
            lblIdUsuarioVenta.ForeColor = SystemColors.Desktop;
            lblIdUsuarioVenta.Location = new Point(25, 88);
            lblIdUsuarioVenta.Name = "lblIdUsuarioVenta";
            lblIdUsuarioVenta.Size = new Size(101, 12);
            lblIdUsuarioVenta.TabIndex = 2;
            lblIdUsuarioVenta.Text = "ID Usuario Venta";
            // 
            // cbComandos
            // 
            cbComandos.FormattingEnabled = true;
            cbComandos.Items.AddRange(new object[] { "Obtener Usuario", "Listar Usuarios", "Crear Usuario", "Modificar Usuario", "Eliminar Usuario", "Obtener Producto", "Listar Productos", "Crear Producto", "Modificar Producto", "Eliminar Producto", "Obtener Producto Vendido", "Listar Productos Vendidos", "Crear Producto Vendido", "Modificar Producto Vendido", "Eliminar Producto Vendido", "Obtener Venta", "Listar Ventas", "Crear Venta", "Modificar Venta", "Eliminar Venta" });
            cbComandos.Location = new Point(29, 98);
            cbComandos.Name = "cbComandos";
            cbComandos.Size = new Size(162, 20);
            cbComandos.TabIndex = 1;
            cbComandos.SelectedIndexChanged += cbComandos_SelectedIndexChanged;
            // 
            // pUsuario
            // 
            pUsuario.BackColor = Color.Transparent;
            pUsuario.BackgroundImageLayout = ImageLayout.None;
            pUsuario.borderRadius = 15F;
            pUsuario.bottom = Color.Purple;
            pUsuario.Controls.Add(tbEmail);
            pUsuario.Controls.Add(lblEmail);
            pUsuario.Controls.Add(tbContra);
            pUsuario.Controls.Add(tbNombreUsuario);
            pUsuario.Controls.Add(tbApellido);
            pUsuario.Controls.Add(lblPassword);
            pUsuario.Controls.Add(lblUserName);
            pUsuario.Controls.Add(lblApellido);
            pUsuario.Controls.Add(lblNombre);
            pUsuario.Controls.Add(tbNombre);
            pUsuario.ForeColor = Color.Transparent;
            pUsuario.Location = new Point(205, 63);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new Size(295, 197);
            pUsuario.TabIndex = 2;
            pUsuario.top = Color.FromArgb(192, 0, 192);
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.RosyBrown;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.ForeColor = SystemColors.Info;
            tbEmail.Location = new Point(129, 147);
            tbEmail.MaxLength = 25;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(144, 21);
            tbEmail.TabIndex = 8;
            // 
            // tbContra
            // 
            tbContra.BackColor = Color.RosyBrown;
            tbContra.BorderStyle = BorderStyle.FixedSingle;
            tbContra.ForeColor = SystemColors.Info;
            tbContra.Location = new Point(129, 117);
            tbContra.MaxLength = 25;
            tbContra.Name = "tbContra";
            tbContra.Size = new Size(144, 21);
            tbContra.TabIndex = 7;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.BackColor = Color.RosyBrown;
            tbNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbNombreUsuario.ForeColor = SystemColors.Info;
            tbNombreUsuario.Location = new Point(129, 87);
            tbNombreUsuario.MaxLength = 25;
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(144, 21);
            tbNombreUsuario.TabIndex = 6;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.RosyBrown;
            tbApellido.BorderStyle = BorderStyle.FixedSingle;
            tbApellido.ForeColor = SystemColors.Info;
            tbApellido.Location = new Point(129, 57);
            tbApellido.MaxLength = 25;
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(144, 21);
            tbApellido.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.RosyBrown;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.ForeColor = SystemColors.Info;
            tbNombre.Location = new Point(129, 27);
            tbNombre.MaxLength = 25;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(144, 21);
            tbNombre.TabIndex = 4;
            // 
            // bMainWindowExit
            // 
            bMainWindowExit.BackColor = Color.Transparent;
            bMainWindowExit.BackgroundImage = Properties.Resources.ExitButton;
            bMainWindowExit.BackgroundImageLayout = ImageLayout.Zoom;
            bMainWindowExit.Cursor = Cursors.Hand;
            bMainWindowExit.FlatAppearance.BorderSize = 0;
            bMainWindowExit.FlatAppearance.MouseDownBackColor = Color.Black;
            bMainWindowExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            bMainWindowExit.FlatStyle = FlatStyle.Flat;
            bMainWindowExit.Location = new Point(520, 10);
            bMainWindowExit.Name = "bMainWindowExit";
            bMainWindowExit.Size = new Size(20, 20);
            bMainWindowExit.TabIndex = 2;
            bMainWindowExit.UseVisualStyleBackColor = false;
            bMainWindowExit.Click += bMainWindowExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Terminus (TTF) for Windows", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = "> Comandos";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.BackgroundColor = Color.SlateBlue;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvData.Location = new Point(50, 315);
            dgvData.Margin = new Padding(5);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(450, 250);
            dgvData.TabIndex = 2;
            // 
            // pProducto
            // 
            pProducto.BackColor = Color.Transparent;
            pProducto.BackgroundImageLayout = ImageLayout.None;
            pProducto.borderRadius = 15F;
            pProducto.bottom = Color.DarkMagenta;
            pProducto.Controls.Add(tbIdUsuario);
            pProducto.Controls.Add(lblIdUsuario);
            pProducto.Controls.Add(tbStock);
            pProducto.Controls.Add(tbPrecioVenta);
            pProducto.Controls.Add(tbCosto);
            pProducto.Controls.Add(lblStock);
            pProducto.Controls.Add(lblPrecioVenta);
            pProducto.Controls.Add(lblCosto);
            pProducto.Controls.Add(lblDescripcion);
            pProducto.Controls.Add(tbDescripcion);
            pProducto.ForeColor = Color.Transparent;
            pProducto.Location = new Point(205, 63);
            pProducto.Name = "pProducto";
            pProducto.Size = new Size(295, 200);
            pProducto.TabIndex = 1;
            pProducto.top = Color.DarkRed;
            // 
            // tbIdUsuario
            // 
            tbIdUsuario.BackColor = Color.RosyBrown;
            tbIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbIdUsuario.ForeColor = SystemColors.Info;
            tbIdUsuario.Location = new Point(129, 147);
            tbIdUsuario.MaxLength = 25;
            tbIdUsuario.Name = "tbIdUsuario";
            tbIdUsuario.Size = new Size(144, 21);
            tbIdUsuario.TabIndex = 9;
            // 
            // tbStock
            // 
            tbStock.BackColor = Color.RosyBrown;
            tbStock.BorderStyle = BorderStyle.FixedSingle;
            tbStock.ForeColor = SystemColors.Info;
            tbStock.Location = new Point(129, 117);
            tbStock.MaxLength = 25;
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(144, 21);
            tbStock.TabIndex = 7;
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.BackColor = Color.RosyBrown;
            tbPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            tbPrecioVenta.ForeColor = SystemColors.Info;
            tbPrecioVenta.Location = new Point(129, 87);
            tbPrecioVenta.MaxLength = 25;
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(144, 21);
            tbPrecioVenta.TabIndex = 6;
            // 
            // tbCosto
            // 
            tbCosto.BackColor = Color.RosyBrown;
            tbCosto.BorderStyle = BorderStyle.FixedSingle;
            tbCosto.ForeColor = SystemColors.Info;
            tbCosto.Location = new Point(129, 57);
            tbCosto.MaxLength = 25;
            tbCosto.Name = "tbCosto";
            tbCosto.Size = new Size(144, 21);
            tbCosto.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.RosyBrown;
            tbDescripcion.BorderStyle = BorderStyle.FixedSingle;
            tbDescripcion.ForeColor = SystemColors.Info;
            tbDescripcion.Location = new Point(129, 27);
            tbDescripcion.MaxLength = 25;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(144, 21);
            tbDescripcion.TabIndex = 0;
            // 
            // pProductoVendido
            // 
            pProductoVendido.BackColor = Color.Transparent;
            pProductoVendido.BackgroundImageLayout = ImageLayout.None;
            pProductoVendido.borderRadius = 15F;
            pProductoVendido.bottom = Color.FromArgb(0, 156, 91);
            pProductoVendido.Controls.Add(tbIdVenta);
            pProductoVendido.Controls.Add(tbStockVenta);
            pProductoVendido.Controls.Add(tbIdProducto);
            pProductoVendido.Controls.Add(lblIdVenta);
            pProductoVendido.Controls.Add(lblStockVenta);
            pProductoVendido.Controls.Add(lblIdProducto);
            pProductoVendido.ForeColor = Color.Transparent;
            pProductoVendido.Location = new Point(205, 63);
            pProductoVendido.Name = "pProductoVendido";
            pProductoVendido.Size = new Size(295, 130);
            pProductoVendido.TabIndex = 7;
            pProductoVendido.top = Color.FromArgb(123, 237, 190);
            // 
            // tbIdVenta
            // 
            tbIdVenta.BackColor = Color.LightGreen;
            tbIdVenta.BorderStyle = BorderStyle.FixedSingle;
            tbIdVenta.ForeColor = SystemColors.Info;
            tbIdVenta.Location = new Point(129, 83);
            tbIdVenta.MaxLength = 25;
            tbIdVenta.Name = "tbIdVenta";
            tbIdVenta.Size = new Size(144, 21);
            tbIdVenta.TabIndex = 5;
            // 
            // tbStockVenta
            // 
            tbStockVenta.BackColor = Color.LightGreen;
            tbStockVenta.BorderStyle = BorderStyle.FixedSingle;
            tbStockVenta.ForeColor = SystemColors.Info;
            tbStockVenta.Location = new Point(129, 53);
            tbStockVenta.MaxLength = 25;
            tbStockVenta.Name = "tbStockVenta";
            tbStockVenta.Size = new Size(144, 21);
            tbStockVenta.TabIndex = 4;
            // 
            // tbIdProducto
            // 
            tbIdProducto.BackColor = Color.LightGreen;
            tbIdProducto.BorderStyle = BorderStyle.FixedSingle;
            tbIdProducto.ForeColor = SystemColors.Info;
            tbIdProducto.Location = new Point(129, 23);
            tbIdProducto.MaxLength = 25;
            tbIdProducto.Name = "tbIdProducto";
            tbIdProducto.Size = new Size(144, 21);
            tbIdProducto.TabIndex = 3;
            // 
            // tbIdEspecifico
            // 
            tbIdEspecifico.BackColor = Color.MistyRose;
            tbIdEspecifico.BorderStyle = BorderStyle.FixedSingle;
            tbIdEspecifico.ForeColor = SystemColors.Desktop;
            tbIdEspecifico.Location = new Point(189, 286);
            tbIdEspecifico.MaxLength = 25;
            tbIdEspecifico.Name = "tbIdEspecifico";
            tbIdEspecifico.Size = new Size(127, 21);
            tbIdEspecifico.TabIndex = 3;
            // 
            // lblEspecificos
            // 
            lblEspecificos.AutoSize = true;
            lblEspecificos.BackColor = Color.Transparent;
            lblEspecificos.Font = new Font("Terminus (TTF) for Windows", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEspecificos.ForeColor = SystemColors.ButtonFace;
            lblEspecificos.Location = new Point(55, 286);
            lblEspecificos.Name = "lblEspecificos";
            lblEspecificos.Size = new Size(128, 17);
            lblEspecificos.TabIndex = 4;
            lblEspecificos.Text = "> ID Especifico";
            lblEspecificos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Restart;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(475, 282);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(25, 25);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExecute
            // 
            btnExecute.Cursor = Cursors.Hand;
            btnExecute.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnExecute.FlatAppearance.BorderSize = 2;
            btnExecute.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnExecute.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btnExecute.FlatStyle = FlatStyle.System;
            btnExecute.ForeColor = SystemColors.ControlText;
            btnExecute.Location = new Point(394, 286);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 21);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // pVenta
            // 
            pVenta.BackColor = Color.Transparent;
            pVenta.borderRadius = 15F;
            pVenta.bottom = Color.FromArgb(192, 255, 255);
            pVenta.Controls.Add(tbIdUsuarioVenta);
            pVenta.Controls.Add(tbComentarios);
            pVenta.Controls.Add(lblIdUsuarioVenta);
            pVenta.Controls.Add(lblComentarios);
            pVenta.Location = new Point(205, 63);
            pVenta.Name = "pVenta";
            pVenta.Size = new Size(295, 132);
            pVenta.TabIndex = 6;
            pVenta.top = Color.FromArgb(255, 255, 128);
            // 
            // tbIdUsuarioVenta
            // 
            tbIdUsuarioVenta.BackColor = Color.LightGreen;
            tbIdUsuarioVenta.BorderStyle = BorderStyle.FixedSingle;
            tbIdUsuarioVenta.ForeColor = SystemColors.Info;
            tbIdUsuarioVenta.Location = new Point(132, 82);
            tbIdUsuarioVenta.MaxLength = 25;
            tbIdUsuarioVenta.Name = "tbIdUsuarioVenta";
            tbIdUsuarioVenta.Size = new Size(144, 21);
            tbIdUsuarioVenta.TabIndex = 5;
            // 
            // tbComentarios
            // 
            tbComentarios.BackColor = Color.LightGreen;
            tbComentarios.BorderStyle = BorderStyle.FixedSingle;
            tbComentarios.ForeColor = SystemColors.Info;
            tbComentarios.Location = new Point(132, 22);
            tbComentarios.MaxLength = 25;
            tbComentarios.Name = "tbComentarios";
            tbComentarios.Size = new Size(144, 21);
            tbComentarios.TabIndex = 4;
            // 
            // lblCurrentCommand
            // 
            lblCurrentCommand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentCommand.AutoSize = true;
            lblCurrentCommand.BackColor = Color.Transparent;
            lblCurrentCommand.ForeColor = SystemColors.ButtonHighlight;
            lblCurrentCommand.Location = new Point(50, 570);
            lblCurrentCommand.Name = "lblCurrentCommand";
            lblCurrentCommand.Size = new Size(89, 12);
            lblCurrentCommand.TabIndex = 8;
            lblCurrentCommand.Text = "CurrentCommand";
            lblCurrentCommand.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(550, 600);
            Controls.Add(lblCurrentCommand);
            Controls.Add(pVenta);
            Controls.Add(pProductoVendido);
            Controls.Add(btnExecute);
            Controls.Add(btnRefresh);
            Controls.Add(lblEspecificos);
            Controls.Add(tbIdEspecifico);
            Controls.Add(pProducto);
            Controls.Add(dgvData);
            Controls.Add(label1);
            Controls.Add(bMainWindowExit);
            Controls.Add(pUsuario);
            Controls.Add(cbComandos);
            Font = new Font("Terminus (TTF) for Windows", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindow_Load;
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pProducto.ResumeLayout(false);
            pProducto.PerformLayout();
            pProductoVendido.ResumeLayout(false);
            pProductoVendido.PerformLayout();
            pVenta.ResumeLayout(false);
            pVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbComandos;
        private Design.PanelGradient pUsuario;
        private Button bMainWindowExit;
        private Label label1;
        private TextBox tbNombre;
        private Label lblNombre;
        private Label lblUserName;
        private Label lblApellido;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox tbContra;
        private TextBox tbNombreUsuario;
        private TextBox tbApellido;
        private TextBox tbEmail;
        private DataGridView dgvData;
        private Design.PanelGradient pProducto;
        private TextBox tbIdUsuario;
        private Label lblIdUsuario;
        private TextBox tbStock;
        private TextBox tbPrecioVenta;
        private TextBox tbCosto;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblDescripcion;
        private TextBox tbDescripcion;
        private TextBox tbIdEspecifico;
        private Label lblEspecificos;
        private Button btnRefresh;
        private Button btnExecute;
        private Design.PanelGradient pProductoVendido;
        private Label lblIdProducto;
        private TextBox tbIdVenta;
        private TextBox tbStockVenta;
        private TextBox tbIdProducto;
        private Design.PanelGradient pVenta;
        private TextBox tbIdUsuarioVenta;
        private TextBox tbComentarios;
        private Label lblCurrentCommand;
    }
}
