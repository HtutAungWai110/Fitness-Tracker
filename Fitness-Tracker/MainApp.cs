using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class MainApp : Form
    {
        private int userId;
        private string userName;

        private int goalId;
        private int calorieGoal = 0;
        private int calorieBurnt = 0;

        CommonMethods methods = new CommonMethods();

        public MainApp(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
            InitializeComponent();
        }
        public MainApp()
        {
            InitializeComponent();
        }

        private void cuiCircleProgressBar1_Load(object sender, EventArgs e)
        {

        }

        private void FetchCalorieGoal()
        {
            Database db = new Database();
            DateTime date = DateTime.Today;
            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT goalId, calorieGoal FROM Goal WHERE userId = @userId and Date = @date";
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    cmd.Parameters.AddWithValue("@userId", this.userId);
                    cmd.Parameters.AddWithValue("@date", date);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
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
            Database db = new Database();
            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT sum(caloriesBurnt) FROM Activity " +
                    "WHERE goalId = @goalId and date = @date GROUP BY goalId;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@goalId", this.goalId);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        this.calorieBurnt = reader.GetInt32(0);
                    }

                    reader.Close();
                    con.Close();

                }
            }
        }

        public void LoadInfo()
        {
            FetchCalorieGoal();
            FetchCalorieBurnt();
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

                setGoalLabel.Visible = false;
                setCalorieBtn.Content = "Reset Goal";


            }
        }
        private void MainApp_Load(object sender, EventArgs e)
        {
            welcomeTxt.Text = "Welcome, " + this.userName;
            float scaleFactor = (float)Screen.PrimaryScreen.Bounds.Width / 1920; // For 1920x1080 reference size
            this.Font = new Font(this.Font.FontFamily, this.Font.Size * scaleFactor);
            LoadInfo();


        }

        private void setCalorieBtn_Click(object sender, EventArgs e)
        {
            string calInput = calorieInput.Content;
            if (!methods.ConvertInt(calInput))
            {
                MessageBox.Show("Enter valid value");
                return;

            }
            User user = new User(this.userId);
            if (calorieGoal <= 0)
            {
                user.SetGoal(int.Parse(calInput));
            }
            else
            {
                user.ResetGoal(int.Parse(calInput), goalId);
            }

            calorieInput.Content = "";

            LoadInfo();
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

     


        private void openWalkingBtn_Click(object sender, EventArgs e)
        {
            if (calorieGoal == 0)
            {
                MessageBox.Show("You haven't set calories goal yet!");
                return;
            }
            ;
            Walking walking = new Walking(this, this.userId, this.goalId);
            walking.Show();
        }

        private void openSwimmingBtn_Click_1(object sender, EventArgs e)
        {
            if (calorieGoal == 0)
            {
                MessageBox.Show("You haven't set calories goal yet!");
                return;
            }
            ;


            Swimming swimming = new Swimming(this, this.userId, this.goalId);
            swimming.Show();
        }

        private void openCyclingBtn_Click(object sender, EventArgs e)
        {
            if (calorieGoal == 0)
            {
                MessageBox.Show("You haven't set calories goal yet!");
                return;
            }
            ;


            Cycling cyclng = new Cycling(this, this.userId, this.goalId);
            cyclng.Show();
        }

        private void openHikingBtn_Click(object sender, EventArgs e)
        {
            if (calorieGoal == 0)
            {
                MessageBox.Show("You haven't set calories goal yet!");
                return;
            }
            ;


            Hiking hiking = new Hiking(this, this.userId, this.goalId);
            hiking.Show();
        }
    }
}
