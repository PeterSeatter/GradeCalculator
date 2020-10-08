using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculation
{
    class GradeWorkingOut : Form
    {
        public static float StudentGradeInput { get; set; }
        public static float StudentPaperInput { get; set; }
        public static float Rounding { get; set; }
        public static string PaperMark { get; set; }

        public static string Letter { get; set; }

        public void Grading()
        {         
            try
            {
                //calls the method which contains the alphabetical grade of the user
                AlphabetGrades();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a value");
            }                        
        }
        //Contains the Alphabetical Grades in realtion to the percentage the user has
        public void AlphabetGrades()
        {
            try
            {
                if (Rounding >= 90 && Rounding <= 100)
                {
                    Letter = "A+";
                }
                else if (Rounding >= 85 && Rounding <= 89)
                {
                    Letter = "A";
                }
                else if (Rounding >= 80 && Rounding <= 84)
                {
                    Letter = "A-";
                }

                else if (Rounding >= 75 && Rounding <= 79)
                {
                    Letter = "B+";
                }

                else if (Rounding >= 70 && Rounding <= 74)
                {
                    Letter = "B";
                }

                else if (Rounding >= 65 && Rounding <= 69)
                {
                    Letter = "B-";
                }

                else if (Rounding >= 60 && Rounding <= 64)
                {
                    Letter = "C+";
                }
                else if (Rounding >= 55 && Rounding <= 59)
                {
                    Letter = "C";
                }
                else if (Rounding >= 50 && Rounding <= 54)
                {
                    Letter = "C-";
                }
                else if (Rounding >= 40 && Rounding <= 49)
                {
                    Letter = "D";
                }
                else if (Rounding >= 0 && Rounding <= 39)
                {
                    Letter = "F";
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Unable to show what you grade is in Alphabet form"); ;
            }
        }
    }
}
