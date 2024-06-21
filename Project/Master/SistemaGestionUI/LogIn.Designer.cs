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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            lblUserName = new Label();
            lblPassword = new Label();
            btnExitLog = new Button();
            pToolBox = new Panel();
            lblEquals = new Label();
            pSeparator = new Panel();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            lblWelcome = new Label();
            pLogIn = new Panel();
            cbPassword = new CheckBox();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            pbUser = new PictureBox();
            lblLogIn = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pToolBox.SuspendLayout();
            pLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.BackColor = Color.Transparent;
            lblUserName.ForeColor = Color.DarkCyan;
            lblUserName.Name = "lblUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.DarkCyan;
            lblPassword.Name = "lblPassword";
            // 
            // btnExitLog
            // 
            btnExitLog.BackColor = Color.Transparent;
            btnExitLog.BackgroundImage = Properties.Resources.ExitButton;
            resources.ApplyResources(btnExitLog, "btnExitLog");
            btnExitLog.Cursor = Cursors.Hand;
            btnExitLog.FlatAppearance.BorderSize = 0;
            btnExitLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            btnExitLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            btnExitLog.Name = "btnExitLog";
            btnExitLog.UseVisualStyleBackColor = false;
            btnExitLog.Click += btnExitLog_Click;
            // 
            // pToolBox
            // 
            pToolBox.BackColor = Color.FromArgb(100, 0, 0, 0);
            pToolBox.Controls.Add(lblEquals);
            pToolBox.Controls.Add(btnExitLog);
            resources.ApplyResources(pToolBox, "pToolBox");
            pToolBox.Name = "pToolBox";
            pToolBox.MouseDown += pToolBox_MouseDown;
            // 
            // lblEquals
            // 
            resources.ApplyResources(lblEquals, "lblEquals");
            lblEquals.BackColor = Color.Transparent;
            lblEquals.Name = "lblEquals";
            // 
            // pSeparator
            // 
            pSeparator.BackColor = Color.FromArgb(150, 0, 0, 0);
            resources.ApplyResources(pSeparator, "pSeparator");
            pSeparator.Name = "pSeparator";
            // 
            // tbUserName
            // 
            resources.ApplyResources(tbUserName, "tbUserName");
            tbUserName.BackColor = Color.Cornsilk;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.ForeColor = SystemColors.WindowText;
            tbUserName.Name = "tbUserName";
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.BackColor = Color.Cornsilk;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.ForeColor = SystemColors.WindowText;
            tbPassword.Name = "tbPassword";
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.FlatStyle = FlatStyle.Flat;
            lblWelcome.Name = "lblWelcome";
            // 
            // pLogIn
            // 
            pLogIn.BackColor = Color.Transparent;
            pLogIn.BackgroundImage = Properties.Resources.Clouds_LogIn;
            resources.ApplyResources(pLogIn, "pLogIn");
            pLogIn.Controls.Add(cbPassword);
            pLogIn.Controls.Add(btnIngresar);
            pLogIn.Controls.Add(pictureBox1);
            pLogIn.Controls.Add(pbUser);
            pLogIn.Controls.Add(lblLogIn);
            pLogIn.Controls.Add(lblUserName);
            pLogIn.Controls.Add(tbUserName);
            pLogIn.Controls.Add(lblPassword);
            pLogIn.Controls.Add(tbPassword);
            pLogIn.Name = "pLogIn";
            // 
            // cbPassword
            // 
            resources.ApplyResources(cbPassword, "cbPassword");
            cbPassword.BackColor = Color.Transparent;
            cbPassword.Cursor = Cursors.Hand;
            cbPassword.ForeColor = Color.Transparent;
            cbPassword.Image = Properties.Resources.Eye1;
            cbPassword.Name = "cbPassword";
            cbPassword.UseVisualStyleBackColor = false;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btnIngresar
            // 
            resources.ApplyResources(btnIngresar, "btnIngresar");
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 175);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 150);
            btnIngresar.ForeColor = SystemColors.GrayText;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Key;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.User;
            resources.ApplyResources(pbUser, "pbUser");
            pbUser.Name = "pbUser";
            pbUser.TabStop = false;
            // 
            // lblLogIn
            // 
            resources.ApplyResources(lblLogIn, "lblLogIn");
            lblLogIn.ForeColor = Color.Teal;
            lblLogIn.Name = "lblLogIn";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Name = "label5";
            // 
            // LogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightSeaGreen;
            resources.ApplyResources(this, "$this");
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pLogIn);
            Controls.Add(lblWelcome);
            Controls.Add(pSeparator);
            Controls.Add(pToolBox);
            DoubleBuffered = true;
            ForeColor = Color.LightGoldenrodYellow;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            Load += LogIn_Load;
            pToolBox.ResumeLayout(false);
            pToolBox.PerformLayout();
            pLogIn.ResumeLayout(false);
            pLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitLog;
        private Panel pToolBox;
        private Panel pSeparator;
        private Label lblUserName;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label lblPassword;
        private Label lblWelcome;
        private Panel pLogIn;
        private Label lblLogIn;
        private PictureBox pbUser;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblEquals;
        private CheckBox cbPassword;
    }
}
