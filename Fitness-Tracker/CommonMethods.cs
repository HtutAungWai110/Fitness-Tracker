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

        public bool ConvertInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                if (result < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;


        }

        public void ShowBtn(cuiTextBox input1, cuiTextBox input2, cuiTextBox input3, cuiButton button)
        {
            if (input1.Content.Trim() != "" && input2.Content.Trim() != "" && input3.Content.Trim() != "")
            {
                button.Visible = true;
            }
            else
            {
                button.Visible = false;
            }
        }

        public void ShowBtn(cuiTextBox input1, cuiTextBox input2, cuiButton button)
        {
            if (input1.Content.Trim() != "" && input2.Content.Trim() != "")
            {
                button.Visible = true;
            }
            else
            {
                button.Visible = false;
            }
        }

        public void ClearTextBoxes(cuiTextBox[] textBoxes)
        {
            foreach (cuiTextBox textBox in textBoxes)
            {
                textBox.Content = string.Empty;  // Sets the TextBox content to an empty string
            }
        }

        public int MetBasedCalulation(int duration, int intensity, int weight, double constant)
        {
            double met;
            switch (intensity)
            {
                case 0:
                    met = 6;
                    break;
                case 1:
                    met = 7.5;
                    break;
                case 2:
                    met = 9.5;
                    break;
                default:
                    met = 6;
                    break;
            }

            int caloriesBurned = (int)Math.Floor((duration * met * weight) / constant);
            return caloriesBurned;
        }

        public int MetBasedCalulation(int duration, int intensity, int weight, double constant, double constantTwo)
        {
            return (int)Math.Floor(MetBasedCalulation(duration, intensity, weight, constant) * constantTwo); 
        }

    }
 
}
