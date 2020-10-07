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

                Letter = Convert.ToString(GradeWorkingOut.Rounding);

                switch (Letter)
                {
                    case "90":
                        if (Rounding >= 90)
                        {
                            Letter = "A+";
                        }
                        break;

                    case "85":
                        if (Rounding >= 85)
                        {
                            Letter = "A";
                        }
                        break;

                    case "80":
                        if (Rounding >= 80)
                        {
                            Letter = "A-";
                        }
                        break;

                    case "75":
                        if (Rounding >= 75)
                        {
                            Letter = "B+";
                        }
                        break;

                    case "70":
                        if (Rounding >= 70)
                        {
                            Letter = "B";
                        }
                        break;

                    case "65":
                        if (Rounding >= 65)
                        {
                            Letter = "B-";
                        }
                        break;

                    case "60":
                        if (Rounding >= 60)
                        {
                            Letter = "C+";
                        }
                        break;

                    case "55":
                        if (Rounding >= 55)
                        {
                            Letter = "C";
                        }
                        break;

                    case "50":
                        if (Rounding >= 50)
                        {
                            Letter = "C-";
                        }
                        break;


                    case "40":
                        if (Rounding >= 40)
                        {
                            Letter = "D";
                        }
                        break;

                    case "0":
                        if (Rounding >= 0)
                        {
                            Letter = "F";
                        }
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to show what you grade is in Alphabet form"); ;
            }
        }
    }
}
