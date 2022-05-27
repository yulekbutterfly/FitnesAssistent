using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesAssistent.Validation
{
    class Calculation
    {
        public static double BMI(double weight, double height)
        {
            double bmi = weight / Math.Pow((height / 100), 2);
            return Math.Round(bmi, 2);
        }

        public static double BMR(double weight, double height, double age, string gender)
        {
            double bmr = 0;

            if (gender == "м")
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            }
            else if (gender == "ж")
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }

            return Math.Round(bmr);
        }
    }
}
