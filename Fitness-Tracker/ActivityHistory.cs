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
    public partial class ActivityHistory : UserControl
    {

        public int no { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int caloreisBurned { get; set; }

        public DateTime date { get; set; }

        

        public ActivityHistory()
        {
            InitializeComponent();
        }

        private void ActivityHistory_Load(object sender, EventArgs e)
        {
            //Setting values on load
            noTxt.Text = this.no.ToString();
            activityNameTxt.Text = this.name;
            caloriesBurnedTxt.Text = "Calories Burned: " + caloreisBurned.ToString();

            if (date == DateTime.Today)
            {
                delBtn.Visible = true;//Show delete button only for today's activities

            }
        }

        private void RemoveActivity()
        {
            History history = (History)this.Parent.Parent.Parent.Parent;
            history.DeleteActivity(this.id);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            RemoveActivity();
        }
    }
}
