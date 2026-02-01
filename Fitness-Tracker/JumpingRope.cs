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
    public partial class JumpingRope : Form
    {
        private int userId;
        private int goalId;
        private Home _mainApp;
        public JumpingRope(Home mainApp, int userId, int goalId)
        {

            InitializeComponent();
            this.userId = userId;
            this.goalId = goalId;
            _mainApp = mainApp;
        }

        public JumpingRope()
        {
            InitializeComponent();
        }

        CommonMethods method = new CommonMethods();

        

        private void SubmitActivity()
        {
            string duration = durationInput.Content;
            string speed = speedInput.Content;
            string weight = weightInput.Content;

            cuiTextBox[] textBoxes = { durationInput, weightInput };

            if (!method.ConvertInt(duration) || !method.ConvertInt(weight) || !method.ConvertInt(speed))
            {
                MessageBox.Show("Enter valid value!");
                return;
            }
            Activity activity = new Activity("Jumping Rope");

            int caloriesBurned = activity.CalJumpingRopeCalories(int.Parse(duration), int.Parse(weight), int.Parse(speed));

            activity.submitActivity(this.userId, this.goalId, caloriesBurned);

            method.ClearTextBoxes(textBoxes);
            this._mainApp.LoadInfo();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SubmitActivity();
        }

        private void durationInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, speedInput, submitBtn);
        }

        private void speedInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, speedInput, submitBtn);
        }

        private void weightInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, speedInput, submitBtn);
        }
    }
}
