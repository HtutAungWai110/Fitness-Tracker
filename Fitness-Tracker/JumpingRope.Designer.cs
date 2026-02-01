namespace Fitness_Tracker
{
    partial class JumpingRope
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.durationInput = new CuoreUI.Controls.cuiTextBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.submitBtn = new CuoreUI.Controls.cuiButton();
            this.weightInput = new CuoreUI.Controls.cuiTextBox();
            this.speedInput = new CuoreUI.Controls.cuiTextBox();
            this.gifBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 253);
            this.label3.MaximumSize = new System.Drawing.Size(800, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Body weight (in kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 183);
            this.label2.MaximumSize = new System.Drawing.Size(800, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Jump speed (jumps / minute):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 111);
            this.label1.MaximumSize = new System.Drawing.Size(800, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Duration (in minutes)";
            // 
            // durationInput
            // 
            this.durationInput.BackgroundColor = System.Drawing.Color.White;
            this.durationInput.Content = "";
            this.durationInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.durationInput.FocusBackgroundColor = System.Drawing.Color.White;
            this.durationInput.FocusImageTint = System.Drawing.Color.White;
            this.durationInput.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.durationInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationInput.ForeColor = System.Drawing.Color.Gray;
            this.durationInput.Image = null;
            this.durationInput.ImageExpand = new System.Drawing.Point(0, 0);
            this.durationInput.ImageOffset = new System.Drawing.Point(0, 0);
            this.durationInput.Location = new System.Drawing.Point(363, 131);
            this.durationInput.Margin = new System.Windows.Forms.Padding(4);
            this.durationInput.MaximumSize = new System.Drawing.Size(800, 500);
            this.durationInput.Multiline = false;
            this.durationInput.Name = "durationInput";
            this.durationInput.NormalImageTint = System.Drawing.Color.White;
            this.durationInput.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.durationInput.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.durationInput.PasswordChar = false;
            this.durationInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.durationInput.PlaceholderText = "Duration";
            this.durationInput.Rounding = new System.Windows.Forms.Padding(8);
            this.durationInput.Size = new System.Drawing.Size(266, 45);
            this.durationInput.TabIndex = 53;
            this.durationInput.TextOffset = new System.Drawing.Size(0, 0);
            this.durationInput.UnderlinedStyle = true;
            this.durationInput.ContentChanged += new System.EventHandler(this.durationInput_ContentChanged);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Fill\\ out\\ the\\ form\\ below\\ to\\ calculate\\ the\\ amount\\ of\\ calories\\ burnt";
            this.cuiLabel1.Font = new System.Drawing.Font("Book Antiqua", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(363, 33);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiLabel1.MaximumSize = new System.Drawing.Size(800, 500);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(407, 58);
            this.cuiLabel1.TabIndex = 51;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // submitBtn
            // 
            this.submitBtn.CheckButton = false;
            this.submitBtn.Checked = false;
            this.submitBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.submitBtn.CheckedForeColor = System.Drawing.Color.White;
            this.submitBtn.CheckedImageTint = System.Drawing.Color.White;
            this.submitBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.submitBtn.Content = "Submit";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.submitBtn.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.submitBtn.HoverForeColor = System.Drawing.Color.White;
            this.submitBtn.HoverImageTint = System.Drawing.Color.White;
            this.submitBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitBtn.Image = null;
            this.submitBtn.ImageAutoCenter = true;
            this.submitBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.submitBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.submitBtn.Location = new System.Drawing.Point(363, 333);
            this.submitBtn.MaximumSize = new System.Drawing.Size(800, 500);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.submitBtn.NormalForeColor = System.Drawing.Color.White;
            this.submitBtn.NormalImageTint = System.Drawing.Color.White;
            this.submitBtn.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitBtn.OutlineThickness = 1F;
            this.submitBtn.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.submitBtn.PressedImageTint = System.Drawing.Color.White;
            this.submitBtn.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitBtn.Rounding = new System.Windows.Forms.Padding(20);
            this.submitBtn.Size = new System.Drawing.Size(150, 50);
            this.submitBtn.TabIndex = 50;
            this.submitBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.submitBtn.TextOffset = new System.Drawing.Point(0, 0);
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // weightInput
            // 
            this.weightInput.BackgroundColor = System.Drawing.Color.White;
            this.weightInput.Content = "";
            this.weightInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightInput.FocusBackgroundColor = System.Drawing.Color.White;
            this.weightInput.FocusImageTint = System.Drawing.Color.White;
            this.weightInput.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.weightInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightInput.ForeColor = System.Drawing.Color.Gray;
            this.weightInput.Image = null;
            this.weightInput.ImageExpand = new System.Drawing.Point(0, 0);
            this.weightInput.ImageOffset = new System.Drawing.Point(0, 0);
            this.weightInput.Location = new System.Drawing.Point(363, 273);
            this.weightInput.Margin = new System.Windows.Forms.Padding(4);
            this.weightInput.MaximumSize = new System.Drawing.Size(800, 500);
            this.weightInput.Multiline = false;
            this.weightInput.Name = "weightInput";
            this.weightInput.NormalImageTint = System.Drawing.Color.White;
            this.weightInput.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.weightInput.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.weightInput.PasswordChar = false;
            this.weightInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.weightInput.PlaceholderText = "Body weight";
            this.weightInput.Rounding = new System.Windows.Forms.Padding(8);
            this.weightInput.Size = new System.Drawing.Size(266, 45);
            this.weightInput.TabIndex = 49;
            this.weightInput.TextOffset = new System.Drawing.Size(0, 0);
            this.weightInput.UnderlinedStyle = true;
            this.weightInput.ContentChanged += new System.EventHandler(this.weightInput_ContentChanged);
            // 
            // speedInput
            // 
            this.speedInput.BackgroundColor = System.Drawing.Color.White;
            this.speedInput.Content = "";
            this.speedInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.speedInput.FocusBackgroundColor = System.Drawing.Color.White;
            this.speedInput.FocusImageTint = System.Drawing.Color.White;
            this.speedInput.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.speedInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedInput.ForeColor = System.Drawing.Color.Gray;
            this.speedInput.Image = null;
            this.speedInput.ImageExpand = new System.Drawing.Point(0, 0);
            this.speedInput.ImageOffset = new System.Drawing.Point(0, 0);
            this.speedInput.Location = new System.Drawing.Point(363, 203);
            this.speedInput.Margin = new System.Windows.Forms.Padding(4);
            this.speedInput.MaximumSize = new System.Drawing.Size(800, 500);
            this.speedInput.Multiline = false;
            this.speedInput.Name = "speedInput";
            this.speedInput.NormalImageTint = System.Drawing.Color.White;
            this.speedInput.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.speedInput.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.speedInput.PasswordChar = false;
            this.speedInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.speedInput.PlaceholderText = "Speed";
            this.speedInput.Rounding = new System.Windows.Forms.Padding(8);
            this.speedInput.Size = new System.Drawing.Size(266, 45);
            this.speedInput.TabIndex = 57;
            this.speedInput.TextOffset = new System.Drawing.Size(0, 0);
            this.speedInput.UnderlinedStyle = true;
            this.speedInput.ContentChanged += new System.EventHandler(this.speedInput_ContentChanged);
            // 
            // gifBox
            // 
            this.gifBox.Image = global::Fitness_Tracker.Properties.Resources.Animation_Skipping_Sticker;
            this.gifBox.InitialImage = null;
            this.gifBox.Location = new System.Drawing.Point(30, 33);
            this.gifBox.MaximumSize = new System.Drawing.Size(800, 500);
            this.gifBox.Name = "gifBox";
            this.gifBox.Size = new System.Drawing.Size(304, 385);
            this.gifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifBox.TabIndex = 52;
            this.gifBox.TabStop = false;
            // 
            // JumpingRope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.speedInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationInput);
            this.Controls.Add(this.gifBox);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.weightInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "JumpingRope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpingRope";
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiTextBox durationInput;
        private System.Windows.Forms.PictureBox gifBox;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton submitBtn;
        private CuoreUI.Controls.cuiTextBox weightInput;
        private CuoreUI.Controls.cuiTextBox speedInput;
    }
}