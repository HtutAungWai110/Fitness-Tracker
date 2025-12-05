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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        CommonMethods method = new CommonMethods();

        private void SignIn()
        {
            string username = userNameTxt.Content;
            string password = passwordTxt.Content;

            if (username.Trim() == "")
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username cannot be empty");
                return;
            }
            else if (username.Length < 3)
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username is too short");
                return;
            }
            else if (username.Length > 20)
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username cannot be longer than 20 characters");
                return;
            }

            if (password.Trim() == "")
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password required");
                return;

            }
            else if (password.Trim().Length < 12 || password.Trim().Length > 12)
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password must be exactly 12 characters");
                return;

            }
            else if (!method.HasLowerUpper(password))
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password must include 1 lower and upper character");
                return;
            }

            User user = new User(username, password);
            user.Login();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SignIn();

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void togglePassword_Click(object sender, EventArgs e)
        {
            method.TogglePassword(togglePassword, passwordTxt);
        }

        private void userNameTxt_ContentChanged(object sender, EventArgs e)
        {
            method.HideError(usernameErrorTxt);
        }

        private void passwordTxt_ContentChanged(object sender, EventArgs e)
        {
            method.HideError(passwordErrorTxt);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
