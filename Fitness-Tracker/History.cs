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
using System.Runtime.InteropServices;


namespace Fitness_Tracker
{
    public partial class History : UserControl
    {

        private int userId;
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();


        private List<GoalData> goals = new List<GoalData>(); //List of goal data
        private List<ActivityData> activities = new List<ActivityData>();//List ofa activity data


        public History()
        {
            InitializeComponent();
        }

        public History(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void FetchGoalData()
        {
            goals.Clear();//Clear old data
            Database database = new Database();
            using (SqlConnection con = database.GetConnection())
            {


                string query = "SELECT goalId, calorieGoal, date FROM Goal WHERE userId = @userId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        activities.Clear();
                        while (reader.Read())
                        {
                            //Fetch data and add to list
                            GoalData goal = new GoalData()
                            {
                                id = reader.GetInt32(0),
                                goal = reader.GetInt32(1),
                                date = reader.GetDateTime(2)
                            };

                            goals.Add(goal);
                        }
                        reader.Close();
                    }

                }
            }
        }

        private void FetchActivityData()
        {
            activities.Clear();//Clear old data
            Database database = new Database();
            using (SqlConnection con = database.GetConnection())
            {
                string activitiesQuery = "select activityId, activityName, goalId, caloriesBurnt, date from Activity where userId = @userId";

                using (SqlCommand cmd = new SqlCommand(activitiesQuery, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        activities.Clear();
                        while (reader.Read())
                        {
                            ActivityData activity = new ActivityData()
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                goalId = reader.GetInt32(2),
                                calorieBurned = reader.GetInt32(3),
                                date = reader.GetDateTime(4)
                            };
                            activities.Add(activity);//Add found data to list
                        }
                        reader.Close();
                    }

                }
            }
        }

       

        private void RenderRecords()
        {
            //This method renders the goal and activity records in the history panel
            historyPanel.Controls.Clear();


            foreach (var goal in this.goals)
            {
                int totalCaloriesBurned = 0;
                int calorieGoal = goal.goal;
                int index = 1;
                GoalHistory gh = new GoalHistory();//Create new GoalHistory control
                gh.Margin = new Padding(0, 10, 0, 10); // spacing between goals

                foreach (var activity in this.activities)
                {
                    if (goal.id == activity.goalId)
                    {
                        ActivityHistory ac = new ActivityHistory()
                        {
                            no = index++,
                            id = activity.id,
                            name = activity.name,
                            caloreisBurned = activity.calorieBurned,
                            date = activity.date,
                            Dock = DockStyle.Top

                        };
                        gh.AddActivity(ac);//Looping through activities and adding to goal



                        totalCaloriesBurned += ac.caloreisBurned;//Calculating total calories burned for the goal
                    }
                }

                gh.progressBarValue = (int)Math.Floor(
                    (double)totalCaloriesBurned / calorieGoal * 100
                ) > 100 ? 100 : (int)Math.Floor(
                    (double)totalCaloriesBurned / calorieGoal * 100
                );//Setting progress bar value withing 0 and max of 100% based of total calories burned

                gh.progressValue = $"{totalCaloriesBurned}/{calorieGoal}";
                gh.date = goal.date;

                historyPanel.Controls.Add(gh);
            }
        }


        public void reload()
        {
            FetchGoalData();
            FetchActivityData();

            RenderRecords();
        }

        public void DeleteActivity(int activityId)
        {
            //Delete an activity with activityId from database and update the UI
            Database db = new Database();
            using (SqlConnection con = db.GetConnection())
            {
                string query = "DELETE FROM Activity WHERE activityId = @activityId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@activityId", activityId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            var item = activities.FirstOrDefault(a => a.id == activityId);
            if (item != null)
            {
                activities.Remove(item);
            }

            RenderRecords();
        }

        private void History_Load(object sender, EventArgs e)
        {
            AllocConsole();
            Console.WriteLine("History Loaded");

        }
    }
}
