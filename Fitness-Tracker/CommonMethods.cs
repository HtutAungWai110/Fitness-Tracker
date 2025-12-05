using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fitness_Tracker
{
    internal class CommonMethods
    {
        public CommonMethods()
        {

        }

        public bool HasLowerUpper(string input)
        {
            bool hasLower = false;
            bool hasUpper = false;

            foreach (char c in input)
            {
                if (char.IsLower(c)) hasLower = true;
                if (char.IsUpper(c)) hasUpper = true;

                // If both are true, we can stop checking
                if (hasLower && hasUpper)
                    return true;
            }

            return false; // Either lower or upper missing
        }

        public void ThrowErrorTxt(System.Windows.Forms.Label label, string output)
        {
            label.Visible = true;
            label.Text = output;
        }

        public void HideError(System.Windows.Forms.Label label)
        {
            if (!label.Visible) return;
            label.Visible = false;
        }

        public void TogglePassword(cuiButton button, cuiTextBox textBox)
        {
            if (button.Content == "Show")
            {
                button.Content = "Hide";
            }
            else
            {
                button.Content = "Show";
            }

            textBox.PasswordChar = !textBox.PasswordChar;
        }
    }
}
