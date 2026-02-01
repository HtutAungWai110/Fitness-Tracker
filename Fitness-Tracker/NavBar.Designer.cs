namespace Fitness_Tracker
{
    partial class NavBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            this.homeBtn = new CuoreUI.Controls.cuiButton();
            this.historyBtn = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.cuiPanel4);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel2.Location = new System.Drawing.Point(0, 0);
            this.cuiPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 2F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(5);
            this.cuiPanel2.Size = new System.Drawing.Size(1000, 150);
            this.cuiPanel2.TabIndex = 32;
            // 
            // cuiPanel4
            // 
            this.cuiPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuiPanel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.Controls.Add(this.homeBtn);
            this.cuiPanel4.Controls.Add(this.historyBtn);
            this.cuiPanel4.Controls.Add(this.label3);
            this.cuiPanel4.Controls.Add(this.label4);
            this.cuiPanel4.Location = new System.Drawing.Point(400, 19);
            this.cuiPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuiPanel4.Name = "cuiPanel4";
            this.cuiPanel4.OutlineThickness = 1F;
            this.cuiPanel4.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.cuiPanel4.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.Size = new System.Drawing.Size(200, 114);
            this.cuiPanel4.TabIndex = 7;
            // 
            // homeBtn
            // 
            this.homeBtn.CheckButton = false;
            this.homeBtn.Checked = false;
            this.homeBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.homeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.homeBtn.CheckedImageTint = System.Drawing.Color.White;
            this.homeBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.homeBtn.Content = "";
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.HoverBackground = System.Drawing.Color.Transparent;
            this.homeBtn.HoverForeColor = System.Drawing.Color.Black;
            this.homeBtn.HoverImageTint = System.Drawing.Color.White;
            this.homeBtn.HoverOutline = System.Drawing.Color.Transparent;
            this.homeBtn.Image = global::Fitness_Tracker.Properties.Resources.home2;
            this.homeBtn.ImageAutoCenter = true;
            this.homeBtn.ImageExpand = new System.Drawing.Point(15, 15);
            this.homeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.homeBtn.Location = new System.Drawing.Point(5, 7);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.homeBtn.NormalForeColor = System.Drawing.Color.Black;
            this.homeBtn.NormalImageTint = System.Drawing.Color.White;
            this.homeBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.homeBtn.OutlineThickness = 1F;
            this.homeBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.homeBtn.PressedImageTint = System.Drawing.Color.White;
            this.homeBtn.PressedOutline = System.Drawing.Color.Transparent;
            this.homeBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.homeBtn.Size = new System.Drawing.Size(69, 70);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.homeBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBtn.CheckButton = false;
            this.historyBtn.Checked = false;
            this.historyBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.historyBtn.CheckedForeColor = System.Drawing.Color.White;
            this.historyBtn.CheckedImageTint = System.Drawing.Color.White;
            this.historyBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.historyBtn.Content = "";
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.historyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.historyBtn.ForeColor = System.Drawing.Color.Black;
            this.historyBtn.HoverBackground = System.Drawing.Color.Transparent;
            this.historyBtn.HoverForeColor = System.Drawing.Color.Black;
            this.historyBtn.HoverImageTint = System.Drawing.Color.White;
            this.historyBtn.HoverOutline = System.Drawing.Color.Transparent;
            this.historyBtn.Image = global::Fitness_Tracker.Properties.Resources.history1;
            this.historyBtn.ImageAutoCenter = true;
            this.historyBtn.ImageExpand = new System.Drawing.Point(15, 15);
            this.historyBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.historyBtn.Location = new System.Drawing.Point(125, 7);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.NormalBackground = System.Drawing.Color.Transparent;
            this.historyBtn.NormalForeColor = System.Drawing.Color.Black;
            this.historyBtn.NormalImageTint = System.Drawing.Color.White;
            this.historyBtn.NormalOutline = System.Drawing.Color.Transparent;
            this.historyBtn.OutlineThickness = 1F;
            this.historyBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.historyBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.historyBtn.PressedImageTint = System.Drawing.Color.White;
            this.historyBtn.PressedOutline = System.Drawing.Color.Transparent;
            this.historyBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.historyBtn.Size = new System.Drawing.Size(69, 70);
            this.historyBtn.TabIndex = 1;
            this.historyBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.historyBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.MinimumSize = new System.Drawing.Size(69, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Home";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 81);
            this.label4.MinimumSize = new System.Drawing.Size(69, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiPanel2);
            this.Name = "NavBar";
            this.Size = new System.Drawing.Size(1000, 150);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel4.ResumeLayout(false);
            this.cuiPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiButton homeBtn;
        private CuoreUI.Controls.cuiButton historyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
