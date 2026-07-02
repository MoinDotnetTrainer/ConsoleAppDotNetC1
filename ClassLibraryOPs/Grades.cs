using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOPs
{
    public class Grades
    {
        public  string GetGrades(int Percentage)
        {
            if (Percentage >= 90 && Percentage <= 100)
            {
                return "A";
            }
            else if (Percentage >= 80 && Percentage <= 89)
            {
                return "B";
            }
            else if (Percentage >= 70 && Percentage <= 79)
            {
                return "C";
            }
            else if (Percentage >= 60 && Percentage <= 69)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }

    
}
