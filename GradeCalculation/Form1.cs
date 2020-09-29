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
    public partial class GradeCalculation : Form
    {
        public GradeCalculation()
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

        public void GradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //creating the object GradeWorkOut which calls on GradeWorkingOut class
                GradeWorkingOut GradeWorkOut = new GradeWorkingOut();
                GradeWorkOut.Grading();
            }
            catch (Exception)
            {
                MessageBox.Show ("It's not communicating with GradeWorkingOut");
            }
        }
    }
}
