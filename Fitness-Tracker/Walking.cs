using CuoreUI.Controls;
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
    public partial class Walking : Form
    {
        private int userId;
        private int goalId;
        private Home _mainApp;
        public Walking(Home mainApp, int userId, int goalId)
        {
            
            InitializeComponent();
            this.userId = userId;
            this.goalId = goalId;
            _mainApp = mainApp;
        }

        public Walking()
        {
            InitializeComponent();
        }

        CommonMethods method = new CommonMethods();

        private void SubmitActivity()
        {
            string steps = stepsInput.Content;
            string distance = distanceInput.Content;
            string time = timeInput.Content;

            cuiTextBox[] textBoxes = { stepsInput, distanceInput, timeInput };

            if (!method.ConvertInt(steps) || !method.ConvertInt(distance) || !method.ConvertInt(time))
            {
                MessageBox.Show("Enter valid value");
                return;
            }
            Activity activity = new Activity("Walking");

            int caloriesBurned = activity.CalWalkingCaloriesBurned(int.Parse(steps), int.Parse(distance), int.Parse(time));

            activity.submitActivity(this.userId, this.goalId, caloriesBurned);
            method.ClearTextBoxes(textBoxes);
            this._mainApp.LoadInfo();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            SubmitActivity();
        }
        private void distanceInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(stepsInput, distanceInput, timeInput, submitBtn);
        }

        private void timeInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(stepsInput, distanceInput, timeInput, submitBtn);
        }

        private void stepsInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(stepsInput, distanceInput, timeInput, submitBtn);
        }
    }
}
