namespace Fitness_Tracker
{
    partial class History
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
            this.historyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // historyPanel
            // 
            this.historyPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historyPanel.AutoScroll = true;
            this.historyPanel.BackColor = System.Drawing.Color.Transparent;
            this.historyPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.historyPanel.Location = new System.Drawing.Point(3, 74);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(1294, 623);
            this.historyPanel.TabIndex = 0;
            this.historyPanel.WrapContents = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 50);
            this.label3.TabIndex = 33;
            this.label3.Text = "Activity History";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.historyPanel);
            this.MinimumSize = new System.Drawing.Size(1300, 690);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1300, 690);
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel historyPanel;
        private System.Windows.Forms.Label label3;
    }
}
