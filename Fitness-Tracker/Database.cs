using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class Database
    {
        private readonly string connectionString =
       @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + GetProjectDirectory() + @"\Fitness.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string GetProjectDirectory()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);
            return directoryInfo.Parent.Parent.FullName;
        }
    }
}
