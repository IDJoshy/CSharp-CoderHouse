namespace Desktop
{
    partial class LogInWindow
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
            LogInExitButton = new Button();
            txtLogin = new Label();
            tbUserName = new TextBox();
            picLogIn = new PictureBox();
            txtUserName = new Label();
            txtPassword = new Label();
            tbPassword = new TextBox();
            bLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogIn).BeginInit();
            SuspendLayout();
            // 
            // LogInExitButton
            // 
            LogInExitButton.BackColor = Color.Transparent;
            LogInExitButton.BackgroundImage = Properties.Resources.ExitButton;
            LogInExitButton.BackgroundImageLayout = ImageLayout.Zoom;
            LogInExitButton.Cursor = Cursors.Hand;
            LogInExitButton.FlatAppearance.BorderSize = 0;
            LogInExitButton.FlatStyle = FlatStyle.Flat;
            LogInExitButton.Location = new Point(261, 12);
            LogInExitButton.Name = "LogInExitButton";
            LogInExitButton.Size = new Size(27, 23);
            LogInExitButton.TabIndex = 0;
            LogInExitButton.UseVisualStyleBackColor = false;
            LogInExitButton.Click += LogInExitButton_Click;
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.Font = new Font("Terminus (TTF) for Windows", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.AntiqueWhite;
            txtLogin.Location = new Point(32, 153);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(89, 19);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "> Log_in";
            txtLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.AllowDrop = true;
            tbUserName.BackColor = SystemColors.ButtonFace;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Cursor = Cursors.IBeam;
            tbUserName.Font = new Font("Terminus (TTF) for Windows", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            tbUserName.ForeColor = Color.Purple;
            tbUserName.Location = new Point(158, 218);
            tbUserName.MaxLength = 12;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(114, 18);
            tbUserName.TabIndex = 2;
            // 
            // picLogIn
            // 
            picLogIn.Anchor = AnchorStyles.None;
            picLogIn.BackColor = Color.Transparent;
            picLogIn.BackgroundImage = Properties.Resources.Profile;
            picLogIn.BackgroundImageLayout = ImageLayout.Zoom;
            picLogIn.Location = new Point(100, 42);
            picLogIn.Name = "picLogIn";
            picLogIn.Size = new Size(100, 83);
            picLogIn.SizeMode = PictureBoxSizeMode.Zoom;
            picLogIn.TabIndex = 3;
            picLogIn.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.BackColor = Color.Transparent;
            txtUserName.Font = new Font("Terminus (TTF) for Windows", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.ControlLight;
            txtUserName.Location = new Point(32, 218);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(88, 17);
            txtUserName.TabIndex = 4;
            txtUserName.Text = "> Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Terminus (TTF) for Windows", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.ControlLight;
            txtPassword.Location = new Point(32, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(112, 17);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "> Contraseña:";
            // 
            // tbPassword
            // 
            tbPassword.AllowDrop = true;
            tbPassword.BackColor = SystemColors.ButtonFace;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Terminus (TTF) for Windows", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.Purple;
            tbPassword.Location = new Point(158, 254);
            tbPassword.MaxLength = 12;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(114, 18);
            tbPassword.TabIndex = 6;
            // 
            // bLogIn
            // 
            bLogIn.BackColor = Color.Transparent;
            bLogIn.Cursor = Cursors.Hand;
            bLogIn.FlatStyle = FlatStyle.Flat;
            bLogIn.Font = new Font("Terminus (TTF) for Windows", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            bLogIn.ForeColor = SystemColors.ControlLightLight;
            bLogIn.Location = new Point(197, 305);
            bLogIn.Name = "bLogIn";
            bLogIn.Size = new Size(75, 25);
            bLogIn.TabIndex = 7;
            bLogIn.Text = "Log-In";
            bLogIn.UseVisualStyleBackColor = false;
            // 
            // LogInWindow
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 7, 54);
            ClientSize = new Size(300, 400);
            Controls.Add(bLogIn);
            Controls.Add(tbPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(picLogIn);
            Controls.Add(tbUserName);
            Controls.Add(txtLogin);
            Controls.Add(LogInExitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInWindow";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInWindow";
            Load += LogInWindow_Load;
            ((System.ComponentModel.ISupportInitialize)picLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogInExitButton;
        private Label txtLogin;
        private TextBox tbUserName;
        private PictureBox picLogIn;
        private Label txtUserName;
        private Label txtPassword;
        private TextBox tbPassword;
        private Button bLogIn;
    }
}