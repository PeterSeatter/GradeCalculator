﻿using System;
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
                string Grade = " ";

                switch (Grade)
                {
                    case "A+":
                        if (Rounding >= 90)
                        {
                            Grade = "A+";
                        }
                        break;

                    case "A":
                        if (Rounding >= 85)
                        {
                            Grade = "A";
                        }
                        break;

                    case "A-":
                        if (Rounding >= 80)
                        {
                            Grade = "A-";
                        }
                        break;

                    case "B+":
                        if (Rounding >= 75)
                        {
                            Grade = "B+";
                        }
                        break;

                    case "B":
                        if (Rounding >= 70)
                        {
                            Grade = "B";
                        }
                        break;

                    case "B-":
                        if (Rounding >= 65)
                        {
                            Grade = "B-";
                        }
                        break;

                    case "C+":
                        if (Rounding >= 60)
                        {
                            Grade = "C+";
                        }
                        break;

                    case "C":
                        if (Rounding >= 55)
                        {
                            Grade = "C";
                        }
                        break;

                    case "C-":
                        if (Rounding >= 50)
                        {
                            Grade = "C-";
                        }
                        break;


                    case "D":
                        if (Rounding >= 40)
                        {
                            Grade = "D";
                        }
                        break;

                    case "F":
                        if (Rounding >= 0)
                        {
                            Grade = "F";
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
