namespace Fitness_Tracker
{
    partial class Login
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
            this.cuiPanelGradient1 = new CuoreUI.Controls.cuiPanelGradient();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.togglePassword = new CuoreUI.Controls.cuiButton();
            this.passwordErrorTxt = new System.Windows.Forms.Label();
            this.usernameErrorTxt = new System.Windows.Forms.Label();
            this.loginBtn = new CuoreUI.Controls.cuiButton();
            this.passwordTxt = new CuoreUI.Controls.cuiTextBox();
            this.userNameTxt = new CuoreUI.Controls.cuiTextBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiPanelGradient1.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanelGradient1
            // 
            this.cuiPanelGradient1.Controls.Add(this.cuiLabel1);
            this.cuiPanelGradient1.Controls.Add(this.cuiPanel1);
            this.cuiPanelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanelGradient1.GradientAngle = 180F;
            this.cuiPanelGradient1.Location = new System.Drawing.Point(0, 0);
            this.cuiPanelGradient1.Name = "cuiPanelGradient1";
            this.cuiPanelGradient1.OutlineThickness = 1F;
            this.cuiPanelGradient1.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(99)))));
            this.cuiPanelGradient1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.cuiPanelGradient1.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.cuiPanelGradient1.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.cuiPanelGradient1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanelGradient1.Size = new System.Drawing.Size(982, 653);
            this.cuiPanelGradient1.TabIndex = 1;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Welcome\\ To\\ GymBros";
            this.cuiLabel1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(250, 25);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(501, 48);
            this.cuiLabel1.TabIndex = 2;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.linkLogin);
            this.cuiPanel1.Controls.Add(this.label2);
            this.cuiPanel1.Controls.Add(this.togglePassword);
            this.cuiPanel1.Controls.Add(this.passwordErrorTxt);
            this.cuiPanel1.Controls.Add(this.usernameErrorTxt);
            this.cuiPanel1.Controls.Add(this.loginBtn);
            this.cuiPanel1.Controls.Add(this.passwordTxt);
            this.cuiPanel1.Controls.Add(this.userNameTxt);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox1);
            this.cuiPanel1.Controls.Add(this.cuiPanel2);
            this.cuiPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Location = new System.Drawing.Point(250, 80);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 0F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiPanel1.Size = new System.Drawing.Size(500, 500);
            this.cuiPanel1.TabIndex = 1;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.Location = new System.Drawing.Point(240, 459);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(89, 17);
            this.linkLogin.TabIndex = 4;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Sign up here";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(68, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doesn\'t have an account?";
            // 
            // togglePassword
            // 
            this.togglePassword.CheckButton = false;
            this.togglePassword.Checked = false;
            this.togglePassword.CheckedBackground = System.Drawing.Color.Transparent;
            this.togglePassword.CheckedForeColor = System.Drawing.Color.Transparent;
            this.togglePassword.CheckedImageTint = System.Drawing.Color.Transparent;
            this.togglePassword.CheckedOutline = System.Drawing.Color.Transparent;
            this.togglePassword.Content = "Show";
            this.togglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.togglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.togglePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.togglePassword.HoverBackground = System.Drawing.Color.Transparent;
            this.togglePassword.HoverForeColor = System.Drawing.Color.Black;
            this.togglePassword.HoverImageTint = System.Drawing.Color.White;
            this.togglePassword.HoverOutline = System.Drawing.Color.Transparent;
            this.togglePassword.Image = null;
            this.togglePassword.ImageAutoCenter = true;
            this.togglePassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.togglePassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.togglePassword.Location = new System.Drawing.Point(374, 307);
            this.togglePassword.Name = "togglePassword";
            this.togglePassword.NormalBackground = System.Drawing.Color.Transparent;
            this.togglePassword.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.togglePassword.NormalImageTint = System.Drawing.Color.White;
            this.togglePassword.NormalOutline = System.Drawing.Color.Transparent;
            this.togglePassword.OutlineThickness = 1F;
            this.togglePassword.PressedBackground = System.Drawing.Color.Transparent;
            this.togglePassword.PressedForeColor = System.Drawing.Color.Gray;
            this.togglePassword.PressedImageTint = System.Drawing.Color.White;
            this.togglePassword.PressedOutline = System.Drawing.Color.Transparent;
            this.togglePassword.Rounding = new System.Windows.Forms.Padding(20);
            this.togglePassword.Size = new System.Drawing.Size(43, 36);
            this.togglePassword.TabIndex = 7;
            this.togglePassword.TextAlignment = System.Drawing.StringAlignment.Center;
            this.togglePassword.TextOffset = new System.Drawing.Point(0, 0);
            this.togglePassword.Click += new System.EventHandler(this.togglePassword_Click);
            // 
            // passwordErrorTxt
            // 
            this.passwordErrorTxt.AutoSize = true;
            this.passwordErrorTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordErrorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorTxt.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorTxt.Location = new System.Drawing.Point(-4, 347);
            this.passwordErrorTxt.MinimumSize = new System.Drawing.Size(500, 20);
            this.passwordErrorTxt.Name = "passwordErrorTxt";
            this.passwordErrorTxt.Size = new System.Drawing.Size(500, 20);
            this.passwordErrorTxt.TabIndex = 5;
            this.passwordErrorTxt.Text = "password error";
            this.passwordErrorTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordErrorTxt.Visible = false;
            // 
            // usernameErrorTxt
            // 
            this.usernameErrorTxt.AutoSize = true;
            this.usernameErrorTxt.BackColor = System.Drawing.Color.Transparent;
            this.usernameErrorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorTxt.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorTxt.Location = new System.Drawing.Point(-4, 277);
            this.usernameErrorTxt.MinimumSize = new System.Drawing.Size(500, 0);
            this.usernameErrorTxt.Name = "usernameErrorTxt";
            this.usernameErrorTxt.Size = new System.Drawing.Size(500, 20);
            this.usernameErrorTxt.TabIndex = 4;
            this.usernameErrorTxt.Text = "username error";
            this.usernameErrorTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameErrorTxt.Visible = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.CheckButton = false;
            this.loginBtn.Checked = false;
            this.loginBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.loginBtn.CheckedForeColor = System.Drawing.Color.White;
            this.loginBtn.CheckedImageTint = System.Drawing.Color.White;
            this.loginBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.loginBtn.Content = "Login";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.loginBtn.HoverForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverImageTint = System.Drawing.Color.White;
            this.loginBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginBtn.Image = null;
            this.loginBtn.ImageAutoCenter = true;
            this.loginBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.loginBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.loginBtn.Location = new System.Drawing.Point(66, 386);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(99)))));
            this.loginBtn.NormalForeColor = System.Drawing.Color.White;
            this.loginBtn.NormalImageTint = System.Drawing.Color.White;
            this.loginBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginBtn.OutlineThickness = 1F;
            this.loginBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.loginBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.loginBtn.PressedImageTint = System.Drawing.Color.White;
            this.loginBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.loginBtn.Size = new System.Drawing.Size(360, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.loginBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BackgroundColor = System.Drawing.Color.White;
            this.passwordTxt.Content = "";
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.passwordTxt.FocusImageTint = System.Drawing.Color.White;
            this.passwordTxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(99)))));
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxt.Image = null;
            this.passwordTxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.passwordTxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.passwordTxt.Location = new System.Drawing.Point(66, 301);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.NormalImageTint = System.Drawing.Color.White;
            this.passwordTxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.passwordTxt.PasswordChar = true;
            this.passwordTxt.PlaceholderColor = System.Drawing.Color.Gray;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.Rounding = new System.Windows.Forms.Padding(10);
            this.passwordTxt.Size = new System.Drawing.Size(360, 45);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.TextOffset = new System.Drawing.Size(0, 0);
            this.passwordTxt.UnderlinedStyle = false;
            this.passwordTxt.ContentChanged += new System.EventHandler(this.passwordTxt_ContentChanged);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTxt.BackgroundColor = System.Drawing.Color.White;
            this.userNameTxt.Content = "";
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.FocusBackgroundColor = System.Drawing.Color.White;
            this.userNameTxt.FocusImageTint = System.Drawing.Color.White;
            this.userNameTxt.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(99)))));
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.Gray;
            this.userNameTxt.Image = null;
            this.userNameTxt.ImageExpand = new System.Drawing.Point(0, 0);
            this.userNameTxt.ImageOffset = new System.Drawing.Point(0, 0);
            this.userNameTxt.Location = new System.Drawing.Point(66, 231);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTxt.Multiline = false;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.NormalImageTint = System.Drawing.Color.White;
            this.userNameTxt.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.userNameTxt.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.userNameTxt.PasswordChar = false;
            this.userNameTxt.PlaceholderColor = System.Drawing.Color.Gray;
            this.userNameTxt.PlaceholderText = "Username";
            this.userNameTxt.Rounding = new System.Windows.Forms.Padding(10);
            this.userNameTxt.Size = new System.Drawing.Size(360, 45);
            this.userNameTxt.TabIndex = 2;
            this.userNameTxt.TextOffset = new System.Drawing.Size(0, 0);
            this.userNameTxt.UnderlinedStyle = false;
            this.userNameTxt.ContentChanged += new System.EventHandler(this.userNameTxt_ContentChanged);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPictureBox1.Content = global::Fitness_Tracker.Properties.Resources.logo;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(200, 89);
            this.cuiPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.cuiPictureBox1.TabIndex = 1;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel2.Controls.Add(this.label1);
            this.cuiPanel2.Location = new System.Drawing.Point(0, 0);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(99)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.cuiPanel2.Size = new System.Drawing.Size(501, 82);
            this.cuiPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(255)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(200, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.cuiPanelGradient1);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.cuiPanelGradient1.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton togglePassword;
        private System.Windows.Forms.Label passwordErrorTxt;
        private System.Windows.Forms.Label usernameErrorTxt;
        private CuoreUI.Controls.cuiButton loginBtn;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private CuoreUI.Controls.cuiTextBox userNameTxt;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.Label label1;
    }
}