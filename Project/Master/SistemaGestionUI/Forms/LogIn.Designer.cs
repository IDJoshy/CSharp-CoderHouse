namespace SistemaGestionUI.Forms
{
    partial class LogIn
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblLogIn;
            Label lblEmail;
            Label lblPassword;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            btnExitLog = new Button();
            btnBack = new Button();
            pToolBox = new Panel();
            pSeparator = new Panel();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            customButton1 = new Design.CustomButton();
            lblLogIn = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            pToolBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.Anchor = AnchorStyles.Top;
            lblLogIn.AutoSize = true;
            lblLogIn.BackColor = Color.Transparent;
            lblLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogIn.Location = new Point(65, 15);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(120, 17);
            lblLogIn.TabIndex = 3;
            lblLogIn.Text = "Account Log-In";
            lblLogIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(25, 98);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(87, 16);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "User Email";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.LightGoldenrodYellow;
            lblPassword.Location = new Point(25, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(71, 16);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnExitLog
            // 
            btnExitLog.BackColor = Color.Transparent;
            btnExitLog.BackgroundImage = Properties.Resources.ExitButton;
            btnExitLog.BackgroundImageLayout = ImageLayout.Zoom;
            btnExitLog.Cursor = Cursors.Hand;
            btnExitLog.FlatAppearance.BorderSize = 0;
            btnExitLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            btnExitLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            btnExitLog.FlatStyle = FlatStyle.Flat;
            btnExitLog.Location = new Point(218, 12);
            btnExitLog.Name = "btnExitLog";
            btnExitLog.Size = new Size(20, 20);
            btnExitLog.TabIndex = 0;
            btnExitLog.UseVisualStyleBackColor = false;
            btnExitLog.Click += btnExitLog_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.BackBtn;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(12, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(20, 20);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pToolBox
            // 
            pToolBox.BackColor = Color.FromArgb(100, 0, 0, 0);
            pToolBox.Controls.Add(lblLogIn);
            pToolBox.Controls.Add(btnExitLog);
            pToolBox.Controls.Add(btnBack);
            pToolBox.Dock = DockStyle.Top;
            pToolBox.Location = new Point(0, 0);
            pToolBox.Name = "pToolBox";
            pToolBox.Size = new Size(250, 45);
            pToolBox.TabIndex = 2;
            pToolBox.MouseDown += pToolBox_MouseDown;
            // 
            // pSeparator
            // 
            pSeparator.BackColor = Color.FromArgb(150, 0, 0, 0);
            pSeparator.Dock = DockStyle.Top;
            pSeparator.Location = new Point(0, 45);
            pSeparator.Name = "pSeparator";
            pSeparator.Size = new Size(250, 10);
            pSeparator.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top;
            tbEmail.BackColor = SystemColors.InactiveCaption;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.ForeColor = SystemColors.WindowText;
            tbEmail.Location = new Point(25, 130);
            tbEmail.MaxLength = 70;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter Email Direction";
            tbEmail.Size = new Size(200, 16);
            tbEmail.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top;
            tbPassword.BackColor = SystemColors.InactiveCaption;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.ForeColor = SystemColors.WindowText;
            tbPassword.Location = new Point(25, 210);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter Password";
            tbPassword.Size = new Size(200, 16);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(100, 0, 0, 0);
            customButton1.BackGroundColor = Color.FromArgb(100, 0, 0, 0);
            customButton1.BorderColor = Color.FromArgb(19, 108, 103);
            customButton1.BorderRadius = 40;
            customButton1.BorderSize = 1;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.WhiteSmoke;
            customButton1.Location = new Point(165, 266);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(73, 40);
            customButton1.TabIndex = 7;
            customButton1.Text = "Accept";
            customButton1.TextColor = Color.WhiteSmoke;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(250, 350);
            ControlBox = false;
            Controls.Add(customButton1);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Controls.Add(pSeparator);
            Controls.Add(pToolBox);
            DoubleBuffered = true;
            ForeColor = Color.LightGoldenrodYellow;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LogIn_Load;
            pToolBox.ResumeLayout(false);
            pToolBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitLog;
        private Button btnBack;
        private Panel pToolBox;
        private Panel pSeparator;
        private Label lblLogIn;
        private Label lblEmail;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Design.CustomButton customButton1;
    }
}
