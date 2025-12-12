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
        private MainApp _mainApp;
        public Walking(MainApp mainApp, int userId, int goalId)
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

        

        public int CalculateCaloriesBurned(int numsOfSteps, int distance, int timeTaken)
        {
            double caloriesPerStep = 0.04;
            double caloriesPerMeter = 0.05;

            int caloriesFromSteps = (int)(numsOfSteps * caloriesPerStep);
            int caloriesFromDistance = (int)(distance * caloriesPerMeter);

            double caloriesPerMinute = 4.5;  
            int caloriesFromTime = (int)(timeTaken * caloriesPerMinute);

           
            int totalCaloriesBurned = caloriesFromSteps + caloriesFromDistance + caloriesFromTime;

            return totalCaloriesBurned;
        }

        

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string steps = stepsInput.Content;
            string distance = distanceInput.Content;
            string time = timeInput.Content;

            cuiTextBox[] textBoxes = {stepsInput, distanceInput, timeInput };

            if (!method.ConvertInt(steps) || !method.ConvertInt(distance) || !method.ConvertInt(time))
            {
                MessageBox.Show("Enter valid value");
                return;
            }

            int caloriesBurnt = CalculateCaloriesBurned(int.Parse(steps), int.Parse(distance), int.Parse(time));
            User user = new User(this.userId, this.goalId);
            user.UpdateActivity("Walking", caloriesBurnt);
            method.ClearTextBoxes(textBoxes);
            this._mainApp.LoadInfo();

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
