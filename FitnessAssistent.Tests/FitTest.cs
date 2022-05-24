using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using FitnesAssistent.Validation;

namespace FitnessAssistent.Tests
{
    [TestClass]
    public class FitTest
    {
            [TestMethod]
            public void ValidationPassword_CorrectPassword_returnTrue()
            {
                //arrange 

                string password = "Watermelon123!";
                bool ex = true;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NullPassword_returnFalse()
            {
                //arrange 

                string password = null;
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NotSymbols_returnFalse()
            {
                //arrange 

                string password = "";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_7symbols_returnFalse()
            {
                //arrange 

                string password = "Nik1i@";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_22symbols_returnFalse()
            {
                //arrange 

                string password = "Bolshe22SymboLl@#ahahahaha!";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_10Spaces_returnFalse()
            {
                //arrange 

                string password = " ";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_OneSpaceInPassword_returnFalse()
            {
                //arrange 

                string password = "Nikk1 Yuk1<3";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NotLowerSymbols_returnFalse()
            {
                //arrange 

                string password = "BOLSHEBUKV1@";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NotUpperSymbols_returnFalse()
            {
                //arrange 

                string password = "menshebukv2$";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NotNumberSymbols_returnFalse()
            {
                //arrange 

                string password = "NoNumber??";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }

            [TestMethod]
            public void ValidationPassword_NotSpecialSymbols_returnFalse()
            {
                //arrange 

                string password = "NoSymbols343";
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationPassword(password);

                //assert 

                Assert.AreEqual(ex, result);
            }


        [TestMethod]
        public void ValidationDateOfBirth_CorrectBith_True()
        {
            //arrange 

            DateTime dateofbirth = Convert.ToDateTime("23/01/2004");
            bool ex = true;

            //act 

            bool result = ValidationResult.ValidationDateOfBirth(dateofbirth);

            //assert 

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
            public void ValidationDateOfBirth_LateThanToday_false()
            {
                //arrange 

                DateTime  dateofbirth = Convert.ToDateTime("23/01/2030");
                bool ex = false;

                //act 

                bool result = ValidationResult.ValidationDateOfBirth(dateofbirth);

                //assert 

                Assert.AreEqual(ex, result);
            }

        [TestMethod]
        public void ValidationWeightHeight_CorrectInput_True()
        {
            //arrange 

            string weightheight = "100";
            bool ex = true;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationWeightHeight_NumMinus_False()
        {
            //arrange 

            string weightheight = "-10";
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationWeightHeightNumNull()
        {
            //arrange 

            string weightheight = "0";
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }


        [TestMethod]
        public void ValidationWeightHeightNumBol()
        {
            //arrange 

            string weightheight = "333";
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }


        [TestMethod]
        public void ValidationWeightHeightNotNum()
        {
            //arrange 

            string weightheight = "fiifi";
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }


        [TestMethod]
        public void ValidationWeightHeightEsc()
        {
            //arrange 

            string weightheight = "    ";
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationNameLName_CorrectNameLName_True()
        {
            //arrange 

            string weightheight = "Qweertyt";
            bool ex = true;

            //act 

            bool result = ValidationResult.ValidationWeightHeight(weightheight);

            //assert 

            Assert.AreEqual(ex, result);
        }




    }
}
