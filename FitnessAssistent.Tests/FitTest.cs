
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using FitnesAssistent.Validation;

namespace FitnessAssistent.Tests
{
    [TestClass]
    public class FitTest
    {
        //ТЕСТ-ПРОВЕРКА ПАРОЛЯ
<<<<<<< HEAD
<<<<<<< HEAD
        [TestMethod]
        public void ValidationPassword_CorrectPassword_returnTrue()
        {
            //arrange 
=======
=======
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
            [TestMethod]
            public void ValidationPassword_CorrectPassword_returnTrue()
            {
                //arrange 

                string password = "Watermelon123!";
                bool ex = true;
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

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

<<<<<<< HEAD
<<<<<<< HEAD
            Assert.AreEqual(ex, result);
        }

=======
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
        //ТЕСТ НА ДАТУ РОЖДЕНИЯ И ВОЗРАСТ
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

            DateTime dateofbirth = Convert.ToDateTime("23/01/2030");
            bool ex = false;

            //act 

            bool result = ValidationResult.ValidationDateOfBirth(dateofbirth);

            //assert 

            Assert.AreEqual(ex, result);
        }



        //ЛОГИН 



        //ЛОГИН 



        //ЛОГИН 

        [TestMethod]
        public void ValidationLogin_CorrectLogin_returnTrue()
        {
            //arrange

            string login = "NekkksaJulia12";
            bool ex = true;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_OccupiedLogin_returnFalse()
        {
            //arrange

            string login = "NEKKA1";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_SpacesInLogin_returnFalse()
        {
            //arrange

            string login = "NEK KA1";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_1Letter_returnFalse()
        {
            //arrange

            string login = "N";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_51Letter_returnFalse()
        {
            //arrange

            string login = "JDSIKJDSNDNJSDKSDMSNDJSDMKSMDKSNDSMDKMSKMDKSDSMDKMKSDS";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_NullLogin_returnFalse()
        {
            //arrange

            string login = null;
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationLogin_OnlyWhiteSpacesLogin_returnFalse()
        {
            //arrange

            string login = "             ";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationLogin(login);
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationLogin(login);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        //Name and Last Name

        [TestMethod]
        public void ValidationName_CorrectName_returnTrue()
        {
            //arrange

            string name = "Nekka";
            bool ex = true;
<<<<<<< HEAD
<<<<<<< HEAD

            //act

            bool result = ValidationResult.ValidationNameLName(name);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_TildaInName_returnTrue()
        {
            //arrange

            string name = "Nekka-Julia";
            bool ex = true;

            //act

            bool result = ValidationResult.ValidationNameLName(name);
=======

=======

>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
            //act

            bool result = Validation.ValidationName(name);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_TildaInName_returnTrue()
        {
            //arrange

            string name = "Nekka-Julia";
            bool ex = true;

            //act

            bool result = Validation.ValidationName(name);
<<<<<<< HEAD
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_WhiteSpaceInName_returnFalse()
        {
            //arrange

            string name = "Nekka Julia";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationNameLName(name);
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_NumberInName_returnFalse()
        {
            //arrange

            string name = "Nek7Jul";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationNameLName(name);
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_1LetterName_returnFalse()
        {
            //arrange

            string name = "N";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationNameLName(name);
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_51LetterInName_returnFalse()
        {
            //arrange

            string name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationNameLName(name);
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_NullName_returnFalse()
        {
            //arrange

            string name = null;
            bool ex = false;

            //act
<<<<<<< HEAD
<<<<<<< HEAD

            bool result = ValidationResult.ValidationNameLName(name);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_OnlySpacesName_returnFalse()
        {
            //arrange

=======

            bool result = Validation.ValidationName(name);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_OnlySpacesName_returnFalse()
        {
            //arrange

>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======

            bool result = Validation.ValidationName(name);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationName_OnlySpacesName_returnFalse()
        {
            //arrange

>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
            string name = "           ";
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationNameLName(name);
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationName(name);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }



        //РОСТ И ВЕС 

        [TestMethod]
        public void ValidationHeight_CorrectHeight_returnTrue()
        {
            //arrange

            string height = "166";
            bool ex = true;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationWeightHeight(height);
=======
            bool result = Validation.ValidationHeight(height);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationHeight_LetterInHeight_returnFalse()
        {
            //arrange

            string height = "1d66";
            bool ex = false;

            //act
<<<<<<< HEAD

            bool result = ValidationResult.ValidationWeightHeight(height);

            //assert

            Assert.AreEqual(ex, result);
        }

=======

            bool result = Validation.ValidationHeight(height);

            //assert

            Assert.AreEqual(ex, result);
        }

>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
        [TestMethod]
        public void ValidationHeight__returnFalse()
        {
            //arrange

            string height = "1";
            bool ex = false;

            //act

<<<<<<< HEAD
            bool result = ValidationResult.ValidationWeightHeight(height);
=======
            bool result = Validation.ValidationHeight(height);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationHeight_Null_returnFalse()
        {
            //arrange

            string height = null;
            bool ex = false;

            //act

<<<<<<< HEAD
            bool result = ValidationResult.ValidationWeightHeight(height);
=======
            bool result = Validation.ValidationHeight(height);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert
=======
            bool result = Validation.ValidationHeight(height);

            //assert
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
<<<<<<< HEAD
        public void ValidationHeight_OnlyWhiteSpaces_returnFalse()
        {
            //arrange

            string height = "           ";
=======
        public void ValidationHeight_LetterInHeight_returnFalse()
        {
            //arrange

            string height = "1d66";
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
            bool ex = false;

            //act

<<<<<<< HEAD
<<<<<<< HEAD
            bool result = ValidationResult.ValidationWeightHeight(height);
=======
            bool result = Validation.ValidationHeight(height);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa
=======
            bool result = Validation.ValidationHeight(height);
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

            //assert

            Assert.AreEqual(ex, result);
        }
<<<<<<< HEAD
=======

        [TestMethod]
        public void ValidationHeight__returnFalse()
        {
            //arrange

            string height = "1";
            bool ex = false;

            //act

            bool result = Validation.ValidationHeight(height);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationHeight_Null_returnFalse()
        {
            //arrange

            string height = null;
            bool ex = false;

            //act

            bool result = Validation.ValidationHeight(height);

            //assert

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void ValidationHeight_OnlyWhiteSpaces_returnFalse()
        {
            //arrange

            string height = "           ";
            bool ex = false;

            //act

            bool result = Validation.ValidationHeight(height);

            //assert

            Assert.AreEqual(ex, result);
        }
>>>>>>> 6bd6f09e8e261400c050bd22524effb50ede74fa

    }
}