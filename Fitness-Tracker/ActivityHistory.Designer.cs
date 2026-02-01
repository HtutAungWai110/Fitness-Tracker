namespace Fitness_Tracker
{
    partial class ActivityHistory
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
            this.noTxt = new System.Windows.Forms.Label();
            this.activityNameTxt = new System.Windows.Forms.Label();
            this.caloriesBurnedTxt = new System.Windows.Forms.Label();
            this.delBtn = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // noTxt
            // 
            this.noTxt.AutoSize = true;
            this.noTxt.Location = new System.Drawing.Point(14, 27);
            this.noTxt.MinimumSize = new System.Drawing.Size(50, 0);
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(50, 16);
            this.noTxt.TabIndex = 0;
            this.noTxt.Text = "No.";
            // 
            // activityNameTxt
            // 
            this.activityNameTxt.AutoSize = true;
            this.activityNameTxt.Location = new System.Drawing.Point(166, 27);
            this.activityNameTxt.MinimumSize = new System.Drawing.Size(150, 0);
            this.activityNameTxt.Name = "activityNameTxt";
            this.activityNameTxt.Size = new System.Drawing.Size(150, 16);
            this.activityNameTxt.TabIndex = 1;
            this.activityNameTxt.Text = "ActivityName";
            // 
            // caloriesBurnedTxt
            // 
            this.caloriesBurnedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caloriesBurnedTxt.AutoSize = true;
            this.caloriesBurnedTxt.Location = new System.Drawing.Point(769, 27);
            this.caloriesBurnedTxt.MinimumSize = new System.Drawing.Size(200, 0);
            this.caloriesBurnedTxt.Name = "caloriesBurnedTxt";
            this.caloriesBurnedTxt.Size = new System.Drawing.Size(200, 16);
            this.caloriesBurnedTxt.TabIndex = 2;
            this.caloriesBurnedTxt.Text = "Calories Burned";
            this.caloriesBurnedTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.CheckButton = false;
            this.delBtn.Checked = false;
            this.delBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.delBtn.CheckedForeColor = System.Drawing.Color.White;
            this.delBtn.CheckedImageTint = System.Drawing.Color.White;
            this.delBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.delBtn.Content = "Delete";
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.HoverBackground = System.Drawing.Color.White;
            this.delBtn.HoverForeColor = System.Drawing.Color.Black;
            this.delBtn.HoverImageTint = System.Drawing.Color.White;
            this.delBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delBtn.Image = null;
            this.delBtn.ImageAutoCenter = true;
            this.delBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.delBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.delBtn.Location = new System.Drawing.Point(1102, 14);
            this.delBtn.Name = "delBtn";
            this.delBtn.NormalBackground = System.Drawing.Color.White;
            this.delBtn.NormalForeColor = System.Drawing.Color.Black;
            this.delBtn.NormalImageTint = System.Drawing.Color.White;
            this.delBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delBtn.OutlineThickness = 1F;
            this.delBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.delBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.delBtn.PressedImageTint = System.Drawing.Color.White;
            this.delBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.delBtn.Size = new System.Drawing.Size(113, 40);
            this.delBtn.TabIndex = 3;
            this.delBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.delBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.delBtn.Visible = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // ActivityHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.caloriesBurnedTxt);
            this.Controls.Add(this.activityNameTxt);
            this.Controls.Add(this.noTxt);
            this.Name = "ActivityHistory";
            this.Size = new System.Drawing.Size(1230, 70);
            this.Load += new System.EventHandler(this.ActivityHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noTxt;
        private System.Windows.Forms.Label activityNameTxt;
        private System.Windows.Forms.Label caloriesBurnedTxt;
        private CuoreUI.Controls.cuiButton delBtn;
    }
}
