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
    public partial class Hiking : Form
    {

        private int userId;
        private int goalId;
        private MainApp _mainApp;
        public Hiking(MainApp mainApp, int userId, int goalId)
        {

            InitializeComponent();
            this.userId = userId;
            this.goalId = goalId;
            _mainApp = mainApp;
        }
        public Hiking()
        {
            InitializeComponent();
        }

        CommonMethods method = new CommonMethods();

        private void submitBtn_Click(object sender, EventArgs e)
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

            int caloriesBurned = method.MetBasedCalulation(int.Parse(duration), intensity, int.Parse(weight), 200.00, 3.50);



            User user = new User(this.userId, this.goalId);
            user.UpdateActivity("Cycling", caloriesBurned);
            method.ClearTextBoxes(textBoxes);
            this._mainApp.LoadInfo();
        }

        private void durationInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, submitBtn);
        }

        private void weightInput_ContentChanged(object sender, EventArgs e)
        {
            method.ShowBtn(durationInput, weightInput, submitBtn);
        }

        private void Hiking_Load(object sender, EventArgs e)
        {
            intensityDropDown.SelectedIndex = 0;
        }
    }
}
