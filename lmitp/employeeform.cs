using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class employeeform : Form
    {
        public employeeform()
        {
            InitializeComponent();
            GenerateExercise();
        }

        private void GenerateExercise()
        {
            Random random = new Random();
            lblNumber1.Text = random.Next(1, 101).ToString();
            lblNumber2.Text = random.Next(1, 101).ToString();

            string[] randomSigns = new string[] { "+", "-", "*", "/" };
            lblSign.Text = randomSigns[random.Next(randomSigns.Length)];
        }
    }
}
