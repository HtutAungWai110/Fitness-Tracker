using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class GoalHistory : UserControl
    {

        public int progressBarValue { get; set; }
        public string progressValue { get; set; }
        public DateTime date { get; set; }

        public GoalHistory()
        {
            InitializeComponent();
        }

        public void AddActivity(ActivityHistory activity)
        {
            activitiesPanel.Controls.Add(activity);
            activity.BringToFront();
        }

        private bool ActivitiesCount()
        {
             return activitiesPanel.Controls.Count > 0;
        }


        private void GoalHistory_Load(object sender, EventArgs e)
        {
            //Setting values on load
            progressBar.Value = this.progressBarValue;
            progressLabel.Text = this.progressValue;
            dateLabel.Text = date == DateTime.Today ? "Today" :  date.ToString("dd/MM/yyyy"); //Setting date to "Today" if the date matches current date
            this.Width = this.Parent.Width - 20;
            activitiesPanel.Width = this.Width - 20;

            if (!ActivitiesCount())
            {
                //Setting a label to indicate no activities if there are none added
                activitiesPanel.Controls.Add(new Label()
                {
                    Text = "No activities recorded for this goal.",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(0, 10, 0, 10)
                });
            }

        }
    }
}
