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
        private string userName;
        private string password;

        public User (string userName, string password)
        {
            this.userName = userName;
            this.password = password; 
        }

        Database database = new Database();
        
        private bool FindExistingUser(string username, SqlConnection con)
        {
  
            string query = "SELECT userName FROM Users WHERE userName = @userName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue ("@userName", username);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();

            return false;
        }

        public void SignUp()
        {
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
                    if (FindExistingUser(this.userName, con))
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

        public void Login()
        {
            SqlConnection con = database.GetConnection();
            try
            {
                string query = "SELECT userName, password FROM Users WHERE userName = @userName and password = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userName", this.userName);
                    cmd.Parameters.AddWithValue("@password", this.password);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Login successful");
                        
                    }
                    else
                    {
                        reader.Close();
                        throw new Exception("Wrong username or password!");
         
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                con.Close(); 
            }

        }
    }
}
