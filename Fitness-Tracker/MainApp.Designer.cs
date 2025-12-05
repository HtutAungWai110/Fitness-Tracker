namespace Fitness_Tracker
{
    partial class MainApp
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
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiCircleProgressBar1 = new CuoreUI.Controls.cuiCircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.cuiButton1);
            this.cuiPanel1.Controls.Add(this.label2);
            this.cuiPanel1.Controls.Add(this.label1);
            this.cuiPanel1.Controls.Add(this.cuiCircleProgressBar1);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 12);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 2F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(10);
            this.cuiPanel1.Size = new System.Drawing.Size(958, 200);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiCircleProgressBar1
            // 
            this.cuiCircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cuiCircleProgressBar1.BorderWidth = 12;
            this.cuiCircleProgressBar1.Location = new System.Drawing.Point(40, 25);
            this.cuiCircleProgressBar1.MaximumValue = 100;
            this.cuiCircleProgressBar1.MinimumSize = new System.Drawing.Size(24, 24);
            this.cuiCircleProgressBar1.MinimumValue = 0;
            this.cuiCircleProgressBar1.Name = "cuiCircleProgressBar1";
            this.cuiCircleProgressBar1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiCircleProgressBar1.ProgressValue = 10;
            this.cuiCircleProgressBar1.RoundedEnds = true;
            this.cuiCircleProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.cuiCircleProgressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "100%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "You haven\'t set calories goal yet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Set Goal";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(223, 86);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiButton1.Size = new System.Drawing.Size(200, 60);
            this.cuiButton1.TabIndex = 1;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.cuiPanel4);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel2.Location = new System.Drawing.Point(0, 833);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 2F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(5);
            this.cuiPanel2.Size = new System.Drawing.Size(982, 120);
            this.cuiPanel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 81);
            this.label4.MinimumSize = new System.Drawing.Size(70, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.MinimumSize = new System.Drawing.Size(70, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Home";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 81);
            this.label5.MinimumSize = new System.Drawing.Size(70, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profile";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuiPanel4
            // 
            this.cuiPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.Controls.Add(this.cuiButton4);
            this.cuiPanel4.Controls.Add(this.cuiButton2);
            this.cuiPanel4.Controls.Add(this.label5);
            this.cuiPanel4.Controls.Add(this.cuiButton3);
            this.cuiPanel4.Controls.Add(this.label3);
            this.cuiPanel4.Controls.Add(this.label4);
            this.cuiPanel4.Location = new System.Drawing.Point(350, 4);
            this.cuiPanel4.Name = "cuiPanel4";
            this.cuiPanel4.OutlineThickness = 1F;
            this.cuiPanel4.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.cuiPanel4.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.Size = new System.Drawing.Size(300, 114);
            this.cuiPanel4.TabIndex = 7;
            // 
            // cuiButton4
            // 
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.Content = "";
            this.cuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton4.ForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverBackground = System.Drawing.Color.White;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton4.Image = global::Fitness_Tracker.Properties.Resources.user1;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(15, 15);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Location = new System.Drawing.Point(225, 8);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton4.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton4.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton4.OutlineThickness = 1F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton4.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton4.Size = new System.Drawing.Size(70, 70);
            this.cuiButton4.TabIndex = 2;
            this.cuiButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.White;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton2.Image = global::Fitness_Tracker.Properties.Resources.home2;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(15, 15);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(5, 8);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(70, 70);
            this.cuiButton2.TabIndex = 0;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.Content = "";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.White;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton3.Image = global::Fitness_Tracker.Properties.Resources.history1;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(15, 15);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(115, 8);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(70, 70);
            this.cuiButton3.TabIndex = 1;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel4.ResumeLayout(false);
            this.cuiPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiCircleProgressBar cuiCircleProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.Label label5;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}