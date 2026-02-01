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
    public partial class Swimming : Form
    {
        private int userId;
        private int goalId;
        private Home _mainApp;
        public Swimming(Home mainApp, int userId, int goalId)
        {

            InitializeComponent();
            this.userId = userId;
            this.goalId = goalId;
            _mainApp = mainApp;
        }
        public Swimming()
        {
            InitializeComponent();
        }

        CommonMethods method = new CommonMethods();
        

        private void durationInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, submitBtn);
        }


        private void weightInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, submitBtn);
        }


        private void SubmitActivity()
        {
            string duration = durationInput.Content;
            int intensity = intensityDropDown.SelectedIndex;
            string weight = weightInput.Content;

            cuiTextBox[] textBoxes = { durationInput, weightInput };

            if (!method.ConvertInt(duration) || !method.ConvertInt(weight))
            {
                MessageBox.Show("Enter valid value!");
                return;
            }



            Activity activity = new Activity("Swimming");

            int caloriesBurned = activity.MetBasedCalulation(int.Parse(duration), intensity, int.Parse(weight), 60.00);

            activity.submitActivity(this.userId, this.goalId, caloriesBurned);


            method.ClearTextBoxes(textBoxes);
            this._mainApp.LoadInfo();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SubmitActivity();
        }

        private void Swimming_Load(object sender, EventArgs e)
        {
            intensityDropDown.SelectedIndex = 0;
        }
    }
}
