using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FitnessAssistent.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
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
}
