using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    internal class User
    {
        private int userId;
        private int goalId;
        private string userName;
        private string password;
        private Login _login;


        
        public User (int userId)
        {
            this.userId = userId;
        }

        public User (string userName, string password, Login login)
        {
            this.userName = userName;
            this.password = password;

            this._login = login;
        }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }

        public User(int userId, int goalId )
        {
            this.userId = userId;
            this.goalId = goalId;
        }

        Database database = new Database();

        
        private bool FindExistingUser(string username, SqlConnection con)
        {
            // Check if user already exists in the database
            string query = "SELECT userName FROM Users WHERE userName = @userName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue ("@userName", username);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                return true;// User exists
            }
            reader.Close();

            return false;// User does not exist
        }

        public void SignUp()
        {
            // Insert new user into the database
            SqlConnection con = database.GetConnection();
            try
            {
                DateTime now = DateTime.Now;
                string query = "INSERT INTO USERS (userName, password, date) VALUES (@userName, @password, @date)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@userName", this.userName);
                    cmd.Parameters.AddWithValue("@password", this.password);
                    cmd.Parameters.AddWithValue("@date", now);
                    if (FindExistingUser(this.userName, con))//User exists and throw error
                    {
                        throw new Exception("User already exist!");
                    }
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successful");
                    

                }
                    


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void LockUserAccount()
        {
            // Set time_out to 5 minutes from now
            using (SqlConnection con = database.GetConnection())
            {
                string query = "UPDATE Users SET time_out = @time_out WHERE userName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DateTime lockoutTime = DateTime.Now.AddMinutes(5);// Lockout for 5 minutes
                    cmd.Parameters.AddWithValue("@time_out", lockoutTime);
                    cmd.Parameters.AddWithValue("@userName", this.userName);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            
        }

        private void UnlockUserAccount(SqlConnection con)
        {
            // Set time_out to NULL
            string query = "UPDATE Users SET time_out = NULL WHERE userName = @userName";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userName", this.userName);
                cmd.ExecuteNonQuery();
            }
        }
        public void Login()
        {
            SqlConnection con = database.GetConnection();
            
            string query = "SELECT userName, password, time_out FROM Users WHERE userName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userName", this.userName);
                    cmd.Parameters.AddWithValue("@password", this.password);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) //User exists
                {
                        string passwordFromDb = reader.GetString(1); //Password from database
                        DateTime? timeOut = reader.GetValue(2) == DBNull.Value // Check for time_out
                            ? (DateTime?)null
                            : (DateTime)reader.GetDateTime(2);


                    reader.Close();

                        if (timeOut > DateTime.Now) //User in time_out

                        {
                            throw new Exception("You are temporarily locked out. Please try again later.");

                        }

                        else if (passwordFromDb != this.password) //incorrect password
                    {
                            _login.IncrementLoginAttempts();
                            throw new Exception("Invalid password");

                        }
                        else
                        {
                            MessageBox.Show("Login successful");
                            UnlockUserAccount(con);
                        }
                            
                    } else
                    {
                        reader.Close(); //User does not exist
                        throw new Exception("User does not exist");
                    }


                }
            

        }

        public int GetUerId()
        {
            // Retrieve userId from database
            using (SqlConnection con = database.GetConnection())
            {
                string query = "SELECT userId FROM Users WHERE userName = @userName and password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userName", this.userName);
                    cmd.Parameters.AddWithValue("@password", this.password);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        return userId; //UserId found
                    }
                    
                    reader.Close();
                    con.Close();
                    return -1; //UserId not found


                }

            }


        }

        public void SetGoal(int calorieGoal) {
            // Insert new goal into the database
            using (SqlConnection con = database.GetConnection()) {

                
                string query = "INSERT INTO Goal (calorieGoal, userId, date) " +
                    "VALUES (@calorieGoal, @userId, @date)";

               

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@calorieGoal", calorieGoal);
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful");

                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }

        }

        public void ResetGoal(int calorieGoal, int goalId) {
            // Update existing goal in the database
            using (SqlConnection con = database.GetConnection())
            {


                string query = "UPDATE Goal SET calorieGoal = @calorieGoal WHERE goalId = @goalId;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@calorieGoal", calorieGoal);
                        cmd.Parameters.AddWithValue("@goalId", goalId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        public void UpdateActivity(string activity, int calorieBurnt)
        {
            // Insert new activity into the database
            using (SqlConnection con = database.GetConnection())
            {


                string query = "INSERT INTO Activity (activityName, userId, goalId, caloriesBurnt, date)" +
                    "VALUES (@activity, @userId, @goalId, @calorieBurnt, @date)";



                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@activity", activity);
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        cmd.Parameters.AddWithValue("@goalId", this.goalId);
                        cmd.Parameters.AddWithValue("@calorieBurnt", calorieBurnt);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You burnt " + calorieBurnt + " calories 🔥");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }
    }
}
