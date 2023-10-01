using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLibraryy;

namespace PasswordLibraryyTests
{
    [TestClass]
    public class PasswordClassTests
    {
        /// <summary>
        /// Пустая строка возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_EmptyString_ReturnedException()
        {
            //Arrange
            string password = "";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// Короткий пароль возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPasswordShortString_ReturnedException()
        {
            //Arrange
            string password = "1dK$";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// Длинный пароль возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_LongString_ReturnedException()
        {
            //Arrange
            string password = "123123123123asFFF$*$123";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        ///  Только маленькие буквы возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_LowerLetters_ReturnedException()
        {
            //Arrange
            string password = "strokasymb";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        ///  Только большие буквы возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_UpLetters_ReturnedException()
        {
            //Arrange
            string password = "SDLUTRHHNMH";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        ///  Только цифры возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_Digits_ReturnedException()
        {
            //Arrange
            string password = "12341236401";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        ///  Только символы возвращает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_SpecSymbols_ReturnedException()
        {
            //Arrange
            string password = "$$$$$()&*^%@@";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        ///  Нормальный пароль буквы возвращает true
        /// </summary>
        [TestMethod]
        public void CheckPassword_GoodPassword1_ReturnedException()
        {
            //Arrange
            string password = "12HTkk^$@5";

            //Act
            PasswordClass obj = new PasswordClass();
            bool actual = obj.CheckPassword(password);
            //Assert
            Assert.IsTrue(actual);
        } /// <summary>
          ///  Нормальный пароль буквы возвращает true
          /// </summary>
        [TestMethod]
        public void CheckPassword_GoodPassword2_ReturnedException()
        {
            //Arrange
            string password = "abVGH$@5";

            //Act
            PasswordClass obj = new PasswordClass();
            bool actual = obj.CheckPassword(password);
            //Assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        ///  Нормальный пароль буквы возвращает true
        /// </summary>
        [TestMethod]
        public void CheckPassword_GoodPassword3_ReturnedException()
        {
            //Arrange
            string password = "abVGH$@5abVGH$@";

            //Act
            PasswordClass obj = new PasswordClass();
            bool actual = obj.CheckPassword(password);
            //Assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Пароль содержащий кириллицу возрващает ошибку
        /// </summary>
        [TestMethod]
        public void CheckPassword_RussianLetters_ReturnedException()
        {
            //Arrange
            string password = "abVGH$@5вbVGH$@@";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
    }
}
