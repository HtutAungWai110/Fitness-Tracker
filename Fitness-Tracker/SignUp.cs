using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }





        CommonMethods method = new CommonMethods();

        private void register()
        {
            string username = userNameTxt.Content;
            string password = passwordTxt.Content;
            string confirmPassword = confirmPasswordTxt.Content;

            if (username.Trim() == "")
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username cannot be empty");
                return;
            }else if(username.Length < 3)
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username is too short");
                return;
            }else if (username.Length > 20)
            {
                method.ThrowErrorTxt(usernameErrorTxt, "Username cannot be longer than 20 characters");
                return;
            }

            if (password.Trim() == "")
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password required");
                return;
                
            }else if(password.Trim().Length < 12 || password.Trim().Length > 12)
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password must be exactly 12 characters long");
                return;
          
            }else if (!method.HasLowerUpper(password))
            {
                method.ThrowErrorTxt(passwordErrorTxt, "Password must include 1 lower and upper character");
                return;
            }

            if (password.Trim() != confirmPassword.Trim())
            {
                method.ThrowErrorTxt(confirmPasswordErrorTxt, "Password doesn't match");
                return;
            }


            User user = new User(username, password);
            user.SignUp();

            userNameTxt.Content = "";
            passwordTxt.Content = "";
            confirmPasswordTxt.Content = "";

      


        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            register();

        }

        

        private void userNameTxt_ContentChanged(object sender, EventArgs e)
        {
            method.HideError(usernameErrorTxt);
        }

        private void passwordTxt_ContentChanged(object sender, EventArgs e)
        {
            method.HideError(passwordErrorTxt);
        }

        private void confirmPasswordTxt_ContentChanged(object sender, EventArgs e)
        {
            method.HideError(confirmPasswordErrorTxt);
        }

        private void togglePassword_Click(object sender, EventArgs e)
        {

            method.TogglePassword(togglePassword, passwordTxt);
        }

        private void toggleConfirmPassword_Click(object sender, EventArgs e)
        {
            method.TogglePassword(toggleConfirmPassword, confirmPasswordTxt);
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            MainApp app = new MainApp();
            app.Show();
        }
    }
}
