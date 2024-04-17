using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class dashboardform : Form
    {
        private int number1;
        private int number2;

        public dashboardform()
        {
            InitializeComponent();
            GenerateExercise();
        }

        private void GenerateExercise()
        {
            // Generate two random numbers between 1 and 100 for the exercise
            Random random = new Random();
            number1 = random.Next(1, 101);
            number2 = random.Next(1, 101);
            string[] signs = new string[] { "+", "-" };
            string sign = signs[random.Next(signs.Length)];

            // Display the numbers in the labels
            lblNumber1.Text = number1.ToString();
            lblSign.Text = sign;
            lblNumber2.Text = number2.ToString();

            // Clear the answer textbox
            txtAnswer.Text = "";
        }

        private async Task CheckAnswer(int userAnswer)
        {
            int correctAnswer;
            // Calculate the correct answer based on the sign
            switch (lblSign.Text)
            {
                case "+":
                    correctAnswer = number1 + number2;
                    break;
                case "-":
                    correctAnswer = number1 - number2;
                    break;
                default:
                    throw new NotImplementedException();
            }

            // Check if the user's answer is correct
            if (userAnswer == correctAnswer)
            {
                RightOrNo.ImageLocation = "C:\\Users\\Denis\\Desktop\\imgs\\check-green.gif";
                // Show a custom message box for correct answer

                TextCorrectOrNo.Text = "Congratulations! Your answer is correct.";
                TextCorrectOrNo.AutoSize = true;
                TextCorrectOrNo.Location = new Point(55, TextCorrectOrNo.Location.Y);
                await Task.Delay(3000);
                TextCorrectOrNo.Text = null;
                RightOrNo.ImageLocation = null;
            }
            else
            {
                RightOrNo.ImageLocation = "C:\\Users\\Denis\\Desktop\\imgs\\error.gif";
                var size = RightOrNo.Size;
                size.Height = 67;
                size.Width = 50;
                RightOrNo.Size = size;
                TextCorrectOrNo.Text = $"Sorry, the correct answer is {correctAnswer}.";

                await Task.Delay(3000);
                TextCorrectOrNo.Text = null;
                RightOrNo.ImageLocation = null;
            }

            // Generate a new exercise after checking the answer
            GenerateExercise();
        }


        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            // Get the user's answer from the textbox
            if (!string.IsNullOrEmpty(txtAnswer.Text))
            {
                if (int.TryParse(txtAnswer.Text, out int userAnswer))
                {
                    // Check the user's answer
                    CheckAnswer(userAnswer);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }
    }
}
