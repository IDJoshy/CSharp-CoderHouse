namespace SistemaGestionUI.Forms
{
    partial class Usuarios
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
            Label lblApellido;
            Label lblNick;
            Label lblContra;
            Label lblEmail;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblUsers = new Label();
            dgvUsuarios = new DataGridView();
            pUser = new Design.CustomPanel();
            tbEmail = new TextBox();
            tbContrasenia = new TextBox();
            tbUserName = new TextBox();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            lblNombre = new Label();
            btnRefresh = new Design.CustomButton();
            lblIDEspecifico = new Label();
            tbIDEspecifico = new TextBox();
            cbCommands = new ComboBox();
            lblComandos = new Label();
            btnEjecutar = new Design.CustomButton();
            lblCurrentCommand = new Label();
            lblApellido = new Label();
            lblNick = new Label();
            lblContra = new Label();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pUser.SuspendLayout();
            SuspendLayout();
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.SlateBlue;
            lblApellido.Location = new Point(18, 43);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(95, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "- Apellido:";
            // 
            // lblNick
            // 
            lblNick.AutoSize = true;
            lblNick.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNick.ForeColor = Color.SlateBlue;
            lblNick.Location = new Point(18, 72);
            lblNick.Name = "lblNick";
            lblNick.Size = new Size(95, 15);
            lblNick.TabIndex = 2;
            lblNick.Text = "- UserName:";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContra.ForeColor = Color.SlateBlue;
            lblContra.Location = new Point(18, 101);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(111, 15);
            lblContra.TabIndex = 3;
            lblContra.Text = "- Contraseña:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.SlateBlue;
            lblEmail.Location = new Point(18, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "- Email:";
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.BackColor = Color.Transparent;
            lblUsers.Font = new Font("Terminus (TTF) for Windows", 15F, FontStyle.Bold);
            lblUsers.ImageAlign = ContentAlignment.MiddleRight;
            lblUsers.Location = new Point(13, 25);
            lblUsers.Name = "lblUsers";
            lblUsers.RightToLeft = RightToLeft.No;
            lblUsers.Size = new Size(110, 21);
            lblUsers.TabIndex = 1;
            lblUsers.Text = "> Usuarios";
            lblUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Dock = DockStyle.Bottom;
            dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsuarios.Location = new Point(10, 257);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.Size = new Size(680, 270);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // pUser
            // 
            pUser.ApplyBorder = true;
            pUser.BackColor = Color.Transparent;
            pUser.BackgroundImageLayout = ImageLayout.None;
            pUser.BorderRadius = 20;
            pUser.ColorBottom = Color.Wheat;
            pUser.ColorTop = Color.Thistle;
            pUser.Controls.Add(tbEmail);
            pUser.Controls.Add(tbContrasenia);
            pUser.Controls.Add(tbUserName);
            pUser.Controls.Add(tbApellido);
            pUser.Controls.Add(tbNombre);
            pUser.Controls.Add(lblEmail);
            pUser.Controls.Add(lblContra);
            pUser.Controls.Add(lblNick);
            pUser.Controls.Add(lblApellido);
            pUser.Controls.Add(lblNombre);
            pUser.ForeColor = Color.Transparent;
            pUser.Location = new Point(312, 25);
            pUser.Name = "pUser";
            pUser.Padding = new Padding(15);
            pUser.Size = new Size(375, 165);
            pUser.TabIndex = 4;
            pUser.Visible = false;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.WhiteSmoke;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Location = new Point(145, 129);
            tbEmail.MaxLength = 24;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Ingresa Email";
            tbEmail.Size = new Size(212, 23);
            tbEmail.TabIndex = 9;
            // 
            // tbContrasenia
            // 
            tbContrasenia.BackColor = Color.WhiteSmoke;
            tbContrasenia.BorderStyle = BorderStyle.FixedSingle;
            tbContrasenia.Location = new Point(145, 100);
            tbContrasenia.MaxLength = 24;
            tbContrasenia.Name = "tbContrasenia";
            tbContrasenia.PlaceholderText = "Ingresa Contraseña";
            tbContrasenia.Size = new Size(212, 23);
            tbContrasenia.TabIndex = 8;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = Color.WhiteSmoke;
            tbUserName.BorderStyle = BorderStyle.FixedSingle;
            tbUserName.Location = new Point(145, 71);
            tbUserName.MaxLength = 24;
            tbUserName.Name = "tbUserName";
            tbUserName.PlaceholderText = "Ingresa UserName";
            tbUserName.Size = new Size(212, 23);
            tbUserName.TabIndex = 7;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.WhiteSmoke;
            tbApellido.BorderStyle = BorderStyle.FixedSingle;
            tbApellido.Location = new Point(145, 42);
            tbApellido.MaxLength = 24;
            tbApellido.Name = "tbApellido";
            tbApellido.PlaceholderText = "Ingresa Apellido";
            tbApellido.Size = new Size(212, 23);
            tbApellido.TabIndex = 6;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.WhiteSmoke;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Location = new Point(145, 13);
            tbNombre.MaxLength = 24;
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Ingresa Nombre";
            tbNombre.Size = new Size(212, 23);
            tbNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.SlateBlue;
            lblNombre.Location = new Point(18, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(79, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "- Nombre:";
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
            // cbCommands
            // 
            cbCommands.BackColor = Color.WhiteSmoke;
            cbCommands.Cursor = Cursors.Hand;
            cbCommands.FlatStyle = FlatStyle.Flat;
            cbCommands.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbCommands.FormattingEnabled = true;
            cbCommands.Items.AddRange(new object[] { "-Seleccionar Comando-", "Obtener Usuario", "Crear Usuario", "Modificar Usuario", "Eliminar Usuario" });
            cbCommands.Location = new Point(30, 100);
            cbCommands.Name = "cbCommands";
            cbCommands.Size = new Size(196, 21);
            cbCommands.TabIndex = 11;
            cbCommands.Text = "-Seleccionar Comando-";
            cbCommands.SelectedIndexChanged += cbCommands_SelectedIndexChanged;
            // 
            // lblComandos
            // 
            lblComandos.AutoSize = true;
            lblComandos.BackColor = Color.Transparent;
            lblComandos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComandos.Location = new Point(30, 70);
            lblComandos.Name = "lblComandos";
            lblComandos.Size = new Size(87, 15);
            lblComandos.TabIndex = 12;
            lblComandos.Text = "- Comandos";
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
            btnEjecutar.TabIndex = 13;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.TextColor = Color.WhiteSmoke;
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblCurrentCommand
            // 
            lblCurrentCommand.AutoSize = true;
            lblCurrentCommand.BackColor = Color.Transparent;
            lblCurrentCommand.Location = new Point(10, 235);
            lblCurrentCommand.Name = "lblCurrentCommand";
            lblCurrentCommand.Size = new Size(107, 12);
            lblCurrentCommand.TabIndex = 14;
            lblCurrentCommand.Text = "Current Command: ";
            // 
            // Usuarios
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
            Controls.Add(pUser);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblUsers);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Usuarios";
            Padding = new Padding(10, 25, 10, 10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pUser.ResumeLayout(false);
            pUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsers;
        private DataGridView dgvUsuarios;
        private Design.CustomPanel pUser;
        private Label lblNombre;
        private Label lblContra;
        private Label lblNick;
        private Label lblApellido;
        private Label lblEmail;
        private Design.CustomButton btnRefresh;
        private TextBox tbNombre;
        private TextBox tbUserName;
        private TextBox tbApellido;
        private TextBox tbEmail;
        private TextBox tbContrasenia;
        private Label lblIDEspecifico;
        private TextBox tbIDEspecifico;
        private ComboBox cbCommands;
        private Label lblComandos;
        private Design.CustomButton btnEjecutar;
        private Label lblCurrentCommand;
    }
}