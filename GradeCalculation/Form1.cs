using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows a decimal point to be added
            var regex = new Regex(@"[^.\s]");

            //only allows numbers and backspace along with the decmial
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void PaperPrecentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //onlys allows numbers and backspace
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void GradeButton_Click(object sender, EventArgs e)
        {
            float StudentGradeInput;
            float StudentPaperInput;
            float Rounding;
            String PaperMark;

            try
            {
                //Gets the inputted student grade and then converts it from text to a float
                StudentGradeInput = float.Parse(StudentGrade.Text);
                //Gets the inputted percentage of the paper/assignment and then converts it from text to a float
                StudentPaperInput = float.Parse(PaperPrecentage.Text);
                //This rounds the float to two decimal places 
                Rounding = (float)Math.Round(StudentGradeInput * StudentPaperInput / 100,2);
                //Outputs the final grade so they know the overall percentage for the paper/assignment            
                OverallGrade.Text = PaperMark = Convert.ToString(Rounding);
            }
            catch (Exception)
            {

                MessageBox.Show ("Please enter a value");
            }


        }
    }
}
