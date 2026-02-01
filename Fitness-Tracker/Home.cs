using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class Home : UserControl
    {
        private int userId;
        private string userName;

        private int goalId;
        private int calorieGoal = 0;
        private int calorieBurnt = 0;
        private Form _recentForm = null;

        CommonMethods methods = new CommonMethods();

        public Home(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
            InitializeComponent();
        }
        public Home()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void FetchCalorieGoal()
        {
            //Fetch calorie goal from database based on userId and today date
            DateTime date = DateTime.Today;
            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT goalId, calorieGoal FROM Goal WHERE userId = @userId and Date = @date";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", this.userId);
                    cmd.Parameters.AddWithValue("@date", date);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // If a record is found, set data accordingly 
                    {
                        this.goalId = reader.GetInt32(0);
                        this.calorieGoal = reader.GetInt32(1);
                    }

                    reader.Close();
                    con.Close();

                }
            }
        }

        private void FetchCalorieBurnt()
        {
            //Fetch total calorie burnt from database based on goalId and today date
            this.calorieBurnt = 0; //Initialize to 0

            using (SqlConnection con = db.GetConnection())
            {
                string query =
                    "SELECT ISNULL(SUM(caloriesBurnt), 0) " +
                    "FROM Activity WHERE goalId = @goalId AND date = @date";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@goalId", this.goalId);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    con.Open();
                    this.calorieBurnt = Convert.ToInt32(cmd.ExecuteScalar());//Set calorieBurnt from database
                    con.Close();
                }
            }
        }






        public void LoadInfo()
        {
            //Load calorie goal and calorie burnt info
            FetchCalorieGoal();
            FetchCalorieBurnt();
            //Additional processes to show information on the form
            if (this.calorieGoal > 0)
            {
                progressCircle.Visible = true;
                caloriesBurntTxt.Visible = true;

                caloriesBurntTxt.Text = this.calorieBurnt + "/" + this.calorieGoal;
                double calorieBurnt = Convert.ToDouble(this.calorieBurnt);
                double calorieGoal = Convert.ToDouble(this.calorieGoal);

                double percentage = Math.Floor((calorieBurnt / calorieGoal) * 100);

                progressCircle.ProgressValue = (int)percentage;

                percentageTxt.Visible = true;
                percentageTxt.Text = percentage.ToString() + "%";
                setCalorieBtn.Content = "Reset Goal";
                setGoalLabel.Visible = false;

            }

        }
   
        private void SetCaloriesGoal()
        {
            //For setting or resetting calorie goal
            string calInput = calorieInput.Content; //Takes input from user
            if (!methods.ConvertInt(calInput))
            {
                MessageBox.Show("Enter valid value");// Input validation
                return;

            }
            User user = new User(this.userId);
            if (calorieGoal <= 0)
            {
                user.SetGoal(int.Parse(calInput)); //Set new goal
            }
            else
            {
                user.ResetGoal(int.Parse(calInput), goalId);//reset existing goal
            }

            calorieInput.Content = "";
            setGoalLabel.Visible = false;
            LoadInfo();
        }

        private void setCalorieBtn_Click(object sender, EventArgs e)
        {


            SetCaloriesGoal();


        }


        private void OpenActivityForm(Form form)
        {
            //Common method to open activity forms
            if (_recentForm != null) _recentForm.Close();
            //if a form is already opened, close it first
            if (calorieGoal == 0)
            {
                //Prevent opening activity form if calorie goal is not set
                MessageBox.Show("You haven't set calories goal yet!");
                return;
            }
            else if (this.calorieBurnt >= this.calorieGoal && this.calorieGoal > 0)
            {
                //Prevent opening activity form if calorie goal is already achieved
                MessageBox.Show("You have already achieved your calorie goal for today! Set new goal!");
                return;
            }
            ;
            _recentForm = form;
            form.Show();
        }


        private void openWalkingBtn_Click(object sender, EventArgs e)
        {

            Walking walking = new Walking(this, this.userId, this.goalId);
            OpenActivityForm(walking);
        }

        private void openSwimmingBtn_Click(object sender, EventArgs e)
        {
            Swimming swimming = new Swimming(this, this.userId, this.goalId);
            OpenActivityForm(swimming);
        }

        private void openCyclingBtn_Click(object sender, EventArgs e)
        {

            Cycling cycling = new Cycling(this, this.userId, this.goalId);
            OpenActivityForm(cycling);
        }

        private void openHikingBtn_Click(object sender, EventArgs e)
        {
            Hiking hiking = new Hiking(this, this.userId, this.goalId);
            OpenActivityForm(hiking);
        }

        private void openYogaBtn_Click(object sender, EventArgs e)
        {
            Yoga yoga = new Yoga(this, this.userId, this.goalId);
            OpenActivityForm(yoga);
        }

        private void openJumpRopeBtn_Click(object sender, EventArgs e)
        {
            JumpingRope jumpingRope = new JumpingRope(this, this.userId, this.goalId);
            OpenActivityForm(jumpingRope);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            welcomeTxt.Text = "Welcome, " + this.userName;
            float scaleFactor = (float)Screen.PrimaryScreen.Bounds.Width / 1920; // For 1920x1080 reference size
            this.Font = new Font(this.Font.FontFamily, this.Font.Size * scaleFactor);
            LoadInfo();
        }
    }
}
