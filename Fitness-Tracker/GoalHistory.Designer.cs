namespace Fitness_Tracker
{
    partial class GoalHistory
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
            this.progressBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
            this.progressLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.activitiesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Background = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBar.Flipped = false;
            this.progressBar.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(846, 20);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.Rounding = 8;
            this.progressBar.Size = new System.Drawing.Size(201, 30);
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 50;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(640, 28);
            this.progressLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.progressLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(200, 20);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "1000/1000";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Location = new System.Drawing.Point(20, 28);
            this.dateLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.dateLabel.MinimumSize = new System.Drawing.Size(250, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(250, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.dateLabel);
            this.cuiPanel1.Controls.Add(this.progressLabel);
            this.cuiPanel1.Controls.Add(this.progressBar);
            this.cuiPanel1.Location = new System.Drawing.Point(0, 0);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(10);
            this.cuiPanel1.Size = new System.Drawing.Size(1065, 71);
            this.cuiPanel1.TabIndex = 3;
            // 
            // activitiesPanel
            // 
            this.activitiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activitiesPanel.AutoSize = true;
            this.activitiesPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.activitiesPanel.Location = new System.Drawing.Point(4, 78);
            this.activitiesPanel.Name = "activitiesPanel";
            this.activitiesPanel.Size = new System.Drawing.Size(1058, 70);
            this.activitiesPanel.TabIndex = 4;
            // 
            // GoalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.activitiesPanel);
            this.Controls.Add(this.cuiPanel1);
            this.Name = "GoalHistory";
            this.Size = new System.Drawing.Size(1065, 151);
            this.Load += new System.EventHandler(this.GoalHistory_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiProgressBarHorizontal progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label dateLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.FlowLayoutPanel activitiesPanel;
    }
}
