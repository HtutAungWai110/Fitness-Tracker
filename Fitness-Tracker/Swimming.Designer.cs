namespace Fitness_Tracker
{
    partial class Swimming
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
            this.gifBox = new System.Windows.Forms.PictureBox();
            this.intensityDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Body weight (in kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Intensity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Duratoin (in minutes)";
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
            this.durationInput.TabIndex = 17;
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
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(407, 58);
            this.cuiLabel1.TabIndex = 15;
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
            this.submitBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.submitBtn.HoverForeColor = System.Drawing.Color.White;
            this.submitBtn.HoverImageTint = System.Drawing.Color.White;
            this.submitBtn.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitBtn.Image = null;
            this.submitBtn.ImageAutoCenter = true;
            this.submitBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.submitBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.submitBtn.Location = new System.Drawing.Point(363, 333);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(158)))));
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
            this.submitBtn.TabIndex = 14;
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
            this.weightInput.TabIndex = 13;
            this.weightInput.TextOffset = new System.Drawing.Size(0, 0);
            this.weightInput.UnderlinedStyle = true;
            this.weightInput.ContentChanged += new System.EventHandler(this.weightInput_ContentChanged);
            // 
            // gifBox
            // 
            this.gifBox.Image = global::Fitness_Tracker.Properties.Resources.Swimming_Pool_Water_Sticker_by_SwimOutlet;
            this.gifBox.InitialImage = global::Fitness_Tracker.Properties.Resources.Happy_T_Shirt_Sticker;
            this.gifBox.Location = new System.Drawing.Point(30, 33);
            this.gifBox.Name = "gifBox";
            this.gifBox.Size = new System.Drawing.Size(304, 385);
            this.gifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifBox.TabIndex = 16;
            this.gifBox.TabStop = false;
            // 
            // intensityDropDown
            // 
            this.intensityDropDown.DisplayMember = "low";
            this.intensityDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intensityDropDown.FormattingEnabled = true;
            this.intensityDropDown.IntegralHeight = false;
            this.intensityDropDown.Items.AddRange(new object[] {
            "low",
            "moderate",
            "extreme"});
            this.intensityDropDown.Location = new System.Drawing.Point(363, 202);
            this.intensityDropDown.Name = "intensityDropDown";
            this.intensityDropDown.Size = new System.Drawing.Size(266, 28);
            this.intensityDropDown.TabIndex = 31;
            // 
            // Swimming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.intensityDropDown);
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
            this.Name = "Swimming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming";
            this.Load += new System.EventHandler(this.Swimming_Load);
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
        private System.Windows.Forms.ComboBox intensityDropDown;
    }
}