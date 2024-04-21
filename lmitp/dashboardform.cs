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
            Random random = new Random();
            number1 = random.Next(1, 101);
            number2 = random.Next(1, 101);
            string[] signs = new string[] { "+", "-" };
            string sign = signs[random.Next(signs.Length)];

            lblNumber1.Text = number1.ToString();
            lblSign.Text = sign;
            lblNumber2.Text = number2.ToString();

            txtAnswer.Text = "";
        }

        private async Task CheckAnswer(int userAnswer)
        {
            int correctAnswer;
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

            if (userAnswer == correctAnswer)
            {
                RightOrNo.ImageLocation = "C:\\Users\\Denis\\Desktop\\imgs\\check-green.gif";

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

            GenerateExercise();
        }


        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnswer.Text))
            {
                if (int.TryParse(txtAnswer.Text, out int userAnswer))
                {
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
