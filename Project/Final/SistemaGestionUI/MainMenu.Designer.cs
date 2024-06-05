using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace SistemaGestionUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pblabel = new PictureBox();
            pbSeparator = new PictureBox();
            pbSearch = new PictureBox();
            pViewSeparator = new PictureBox();
            bMainMenuExit = new Button();
            pSideBar = new Design.CustomPanel();
            btnReports = new Design.CustomButton();
            btnVentas = new Design.CustomButton();
            btnProductos = new Design.CustomButton();
            btnUsuarios = new Design.CustomButton();
            btnHomeView = new Design.CustomButton();
            bLog = new Button();
            pLabel = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            pTool = new Panel();
            pUserLogged = new Panel();
            lblTypeUser = new Label();
            lblUserName = new Label();
            pbUserImage = new PictureBox();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pblabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSeparator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pViewSeparator).BeginInit();
            pSideBar.SuspendLayout();
            pLabel.SuspendLayout();
            pTool.SuspendLayout();
            pUserLogged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).BeginInit();
            SuspendLayout();
            // 
            // pblabel
            // 
            pblabel.BackColor = Color.Transparent;
            pblabel.BackgroundImageLayout = ImageLayout.None;
            pblabel.Image = Properties.Resources.Default_Icon;
            pblabel.Location = new Point(14, 46);
            pblabel.Margin = new Padding(5);
            pblabel.Name = "pblabel";
            pblabel.Padding = new Padding(5);
            pblabel.Size = new Size(50, 50);
            pblabel.SizeMode = PictureBoxSizeMode.Zoom;
            pblabel.TabIndex = 0;
            pblabel.TabStop = false;
            // 
            // pbSeparator
            // 
            pbSeparator.BackColor = Color.FromArgb(50, 0, 0, 0);
            pbSeparator.Dock = DockStyle.Top;
            pbSeparator.Location = new Point(0, 150);
            pbSeparator.Name = "pbSeparator";
            pbSeparator.Size = new Size(200, 10);
            pbSeparator.TabIndex = 1;
            pbSeparator.TabStop = false;
            // 
            // pbSearch
            // 
            pbSearch.BackColor = Color.Transparent;
            pbSearch.BackgroundImageLayout = ImageLayout.None;
            pbSearch.Image = Properties.Resources.Selected;
            pbSearch.Location = new Point(19, 12);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(25, 25);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 4;
            pbSearch.TabStop = false;
            // 
            // pViewSeparator
            // 
            pViewSeparator.BackColor = Color.FromArgb(150, 0, 0, 0);
            pViewSeparator.Dock = DockStyle.Top;
            pViewSeparator.Location = new Point(200, 50);
            pViewSeparator.Name = "pViewSeparator";
            pViewSeparator.Size = new Size(700, 13);
            pViewSeparator.TabIndex = 3;
            pViewSeparator.TabStop = false;
            // 
            // bMainMenuExit
            // 
            bMainMenuExit.BackColor = Color.Transparent;
            bMainMenuExit.BackgroundImage = Properties.Resources.ExitButton;
            bMainMenuExit.BackgroundImageLayout = ImageLayout.Zoom;
            bMainMenuExit.Cursor = Cursors.Hand;
            bMainMenuExit.FlatAppearance.BorderSize = 0;
            bMainMenuExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            bMainMenuExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            bMainMenuExit.FlatStyle = FlatStyle.Flat;
            bMainMenuExit.Location = new Point(663, 12);
            bMainMenuExit.Name = "bMainMenuExit";
            bMainMenuExit.Size = new Size(25, 25);
            bMainMenuExit.TabIndex = 0;
            bMainMenuExit.UseVisualStyleBackColor = false;
            bMainMenuExit.Click += bMainMenuExit_Click;
            // 
            // pSideBar
            // 
            pSideBar.ApplyBorder = false;
            pSideBar.BackColor = Color.FromArgb(100, 0, 0, 0);
            pSideBar.BorderRadius = 0;
            pSideBar.ColorBottom = Color.FromArgb(8, 126, 139);
            pSideBar.ColorTop = Color.FromArgb(11, 57, 84);
            pSideBar.Controls.Add(btnReports);
            pSideBar.Controls.Add(btnVentas);
            pSideBar.Controls.Add(btnProductos);
            pSideBar.Controls.Add(btnUsuarios);
            pSideBar.Controls.Add(btnHomeView);
            pSideBar.Controls.Add(bLog);
            pSideBar.Controls.Add(pbSeparator);
            pSideBar.Controls.Add(pLabel);
            pSideBar.Dock = DockStyle.Left;
            pSideBar.ForeColor = Color.Transparent;
            pSideBar.Location = new Point(0, 0);
            pSideBar.Name = "pSideBar";
            pSideBar.Size = new Size(200, 600);
            pSideBar.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.MediumSeaGreen;
            btnReports.BackGroundColor = Color.MediumSeaGreen;
            btnReports.BackgroundImageLayout = ImageLayout.Center;
            btnReports.BorderColor = Color.PaleTurquoise;
            btnReports.BorderRadius = 15;
            btnReports.BorderSize = 1;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.WhiteSmoke;
            btnReports.Image = Properties.Resources.Reports;
            btnReports.ImageAlign = ContentAlignment.MiddleRight;
            btnReports.Location = new Point(0, 360);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(40, 0, 25, 0);
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reportes";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextColor = Color.WhiteSmoke;
            btnReports.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.MediumSeaGreen;
            btnVentas.BackGroundColor = Color.MediumSeaGreen;
            btnVentas.BackgroundImageLayout = ImageLayout.Center;
            btnVentas.BorderColor = Color.PaleTurquoise;
            btnVentas.BorderRadius = 15;
            btnVentas.BorderSize = 1;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnVentas.ForeColor = Color.WhiteSmoke;
            btnVentas.Image = Properties.Resources.Sales;
            btnVentas.ImageAlign = ContentAlignment.MiddleRight;
            btnVentas.Location = new Point(0, 310);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(40, 0, 25, 0);
            btnVentas.Size = new Size(200, 50);
            btnVentas.TabIndex = 7;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextColor = Color.WhiteSmoke;
            btnVentas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.MediumSeaGreen;
            btnProductos.BackGroundColor = Color.MediumSeaGreen;
            btnProductos.BackgroundImageLayout = ImageLayout.Center;
            btnProductos.BorderColor = Color.PaleTurquoise;
            btnProductos.BorderRadius = 15;
            btnProductos.BorderSize = 1;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.WhiteSmoke;
            btnProductos.Image = Properties.Resources.Products;
            btnProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnProductos.Location = new Point(0, 260);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(40, 0, 27, 0);
            btnProductos.Size = new Size(200, 50);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextColor = Color.WhiteSmoke;
            btnProductos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.MediumSeaGreen;
            btnUsuarios.BackGroundColor = Color.MediumSeaGreen;
            btnUsuarios.BackgroundImageLayout = ImageLayout.Center;
            btnUsuarios.BorderColor = Color.PaleTurquoise;
            btnUsuarios.BorderRadius = 15;
            btnUsuarios.BorderSize = 1;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.WhiteSmoke;
            btnUsuarios.Image = Properties.Resources.User;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleRight;
            btnUsuarios.Location = new Point(0, 210);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(40, 0, 29, 0);
            btnUsuarios.Size = new Size(200, 50);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextColor = Color.WhiteSmoke;
            btnUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnHomeView
            // 
            btnHomeView.BackColor = Color.MediumSeaGreen;
            btnHomeView.BackGroundColor = Color.MediumSeaGreen;
            btnHomeView.BackgroundImageLayout = ImageLayout.Center;
            btnHomeView.BorderColor = Color.PaleTurquoise;
            btnHomeView.BorderRadius = 15;
            btnHomeView.BorderSize = 1;
            btnHomeView.Dock = DockStyle.Top;
            btnHomeView.FlatAppearance.BorderSize = 0;
            btnHomeView.FlatStyle = FlatStyle.Flat;
            btnHomeView.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnHomeView.ForeColor = Color.WhiteSmoke;
            btnHomeView.Image = Properties.Resources.HomeButton;
            btnHomeView.ImageAlign = ContentAlignment.MiddleRight;
            btnHomeView.Location = new Point(0, 160);
            btnHomeView.Name = "btnHomeView";
            btnHomeView.Padding = new Padding(40, 0, 25, 0);
            btnHomeView.Size = new Size(200, 50);
            btnHomeView.TabIndex = 4;
            btnHomeView.Text = "Home";
            btnHomeView.TextAlign = ContentAlignment.MiddleLeft;
            btnHomeView.TextColor = Color.WhiteSmoke;
            btnHomeView.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHomeView.UseVisualStyleBackColor = false;
            btnHomeView.Click += btnHomeView_Click;
            // 
            // bLog
            // 
            bLog.BackColor = Color.FromArgb(50, 0, 0, 0);
            bLog.Dock = DockStyle.Bottom;
            bLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 35, 51);
            bLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(8, 116, 131);
            bLog.FlatStyle = FlatStyle.Flat;
            bLog.ForeColor = Color.Tomato;
            bLog.Location = new Point(0, 554);
            bLog.Name = "bLog";
            bLog.Size = new Size(200, 46);
            bLog.TabIndex = 3;
            bLog.Text = "Log-In/Log-Out";
            bLog.UseVisualStyleBackColor = false;
            bLog.Click += bLog_Click;
            // 
            // pLabel
            // 
            pLabel.BackColor = Color.Transparent;
            pLabel.BackgroundImageLayout = ImageLayout.None;
            pLabel.Controls.Add(lblSubTitle);
            pLabel.Controls.Add(lblTitle);
            pLabel.Controls.Add(pblabel);
            pLabel.Dock = DockStyle.Top;
            pLabel.ForeColor = Color.Transparent;
            pLabel.Location = new Point(0, 0);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(200, 150);
            pLabel.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Terminus (TTF) for Windows", 9F, FontStyle.Bold);
            lblSubTitle.Location = new Point(100, 84);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(85, 17);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Gestor Ventas";
            lblSubTitle.UseCompatibleTextRendering = true;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Terminus (TTF) for Windows", 15F, FontStyle.Bold);
            lblTitle.Location = new Point(69, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 26);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Ephemeral";
            lblTitle.UseCompatibleTextRendering = true;
            // 
            // pTool
            // 
            pTool.BackColor = Color.FromArgb(100, 0, 0, 0);
            pTool.Controls.Add(pUserLogged);
            pTool.Controls.Add(tbSearch);
            pTool.Controls.Add(pbSearch);
            pTool.Controls.Add(bMainMenuExit);
            pTool.Dock = DockStyle.Top;
            pTool.Location = new Point(200, 0);
            pTool.Name = "pTool";
            pTool.Size = new Size(700, 50);
            pTool.TabIndex = 2;
            pTool.Paint += pTool_Paint;
            pTool.MouseDown += pTool_MouseDown;
            // 
            // pUserLogged
            // 
            pUserLogged.BackColor = Color.FromArgb(50, 0, 0, 0);
            pUserLogged.Controls.Add(lblTypeUser);
            pUserLogged.Controls.Add(lblUserName);
            pUserLogged.Controls.Add(pbUserImage);
            pUserLogged.Location = new Point(499, 0);
            pUserLogged.Name = "pUserLogged";
            pUserLogged.Size = new Size(145, 50);
            pUserLogged.TabIndex = 6;
            // 
            // lblTypeUser
            // 
            lblTypeUser.AutoSize = true;
            lblTypeUser.BackColor = Color.Transparent;
            lblTypeUser.Font = new Font("Terminus (TTF) for Windows", 9F, FontStyle.Bold);
            lblTypeUser.Location = new Point(49, 31);
            lblTypeUser.Name = "lblTypeUser";
            lblTypeUser.Size = new Size(79, 17);
            lblTypeUser.TabIndex = 2;
            lblTypeUser.Text = "Tipo de User";
            lblTypeUser.UseCompatibleTextRendering = true;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Terminus (TTF) for Windows", 9F, FontStyle.Bold);
            lblUserName.ImageAlign = ContentAlignment.MiddleLeft;
            lblUserName.Location = new Point(49, 8);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 17);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Nombre de User";
            lblUserName.UseCompatibleTextRendering = true;
            // 
            // pbUserImage
            // 
            pbUserImage.Anchor = AnchorStyles.Left;
            pbUserImage.Location = new Point(5, 5);
            pbUserImage.Name = "pbUserImage";
            pbUserImage.Size = new Size(40, 40);
            pbUserImage.TabIndex = 0;
            pbUserImage.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.AllowDrop = true;
            tbSearch.BackColor = Color.FromArgb(21, 127, 126);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.ForeColor = Color.WhiteSmoke;
            tbSearch.Location = new Point(50, 17);
            tbSearch.MaxLength = 100;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = " Search ";
            tbSearch.Size = new Size(184, 16);
            tbSearch.TabIndex = 5;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(41, 57, 127);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 600);
            ControlBox = false;
            Controls.Add(pViewSeparator);
            Controls.Add(pTool);
            Controls.Add(pSideBar);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pblabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSeparator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pViewSeparator).EndInit();
            pSideBar.ResumeLayout(false);
            pLabel.ResumeLayout(false);
            pLabel.PerformLayout();
            pTool.ResumeLayout(false);
            pTool.PerformLayout();
            pUserLogged.ResumeLayout(false);
            pUserLogged.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bMainMenuExit;
        private Design.CustomPanel pSideBar;
        private Panel pTool;
        private PictureBox pblabel;
        private Panel pLabel;
        private Button bLog;
        private PictureBox pbSearch;
        private TextBox tbSearch;
        private Label lblTitle;
        private Label lblSubTitle;
        private Design.CustomButton btnHomeView;
        private Design.CustomButton btnProductos;
        private Design.CustomButton btnUsuarios;
        private Design.CustomButton btnVentas;
        private Design.CustomButton btnReports;
        private Panel pUserLogged;
        private PictureBox pbUserImage;
        private Label lblUserName;
        private Label lblTypeUser;
        private PictureBox pbSeparator;
        private PictureBox pViewSeparator;
    }
}
