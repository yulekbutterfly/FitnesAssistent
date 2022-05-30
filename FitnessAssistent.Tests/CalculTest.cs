using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FitnesAssistent.Validation; 


namespace FitnessAssistent.Tests
{
    [TestClass]
    public class CalculTest
    {

            [TestMethod]
            public void BMI_WeightHeight()
            {
                //arrange

                double weight = 65;
                double height = 166;

                double ex = 23.59;

                //act

                double result = Calculation.BMI(weight, height);

                //assert

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void BMR_WeightHeightAgeGenderMale()
            {
                //arrange

                double weight = 65;
                double height = 166;
                double age = 18;
                string gender = "м";

                double ex = 1602;

                //act

                double result = Calculation.BMR(weight, height, age, gender);

                //assert

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void BMR_WeightHeightAgeGenderFemale()
            {
                //arrange

                double weight = 66;
                double height = 165;
                double age = 18;
                string gender = "ж";

                double ex = 1440;

                //act

                double result = Calculation.BMR(weight, height, age, gender);

                //assert

                Assert.AreEqual(ex, result);
            }
    }
}
