using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;

namespace BankTests
{
    [TestClass]
    public class BankAppTests
    {
        [TestMethod]
        [TestCategory("BankActions")]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            //Arrange
            double startingBalance = 300.00;
            double expectedResult = 350.00;

            //Act
            BankAccount f = new BankAccount(1444, "Patrick", startingBalance);
            f.Deposit(50);

            //Assert
            Assert.AreEqual(expectedResult, f.Balance);
        }

        [TestMethod]
        [TestCategory("BankActions")]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            //Arrange
            double startingBalance = 300.00;
            double expectedResult = 250.00;

            //Act
            BankAccount f = new BankAccount(1444, "Patrick", startingBalance);
            f.Withdraw(50);

            //Assert
            Assert.AreEqual(expectedResult, f.Balance);
        }

        [TestMethod]
        [TestCategory("ExceptionChecking")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_MoreThanBalance_Exception()
        {
            //Arrange
            double startingBalance = 50;
            double expectedResult = -50;

            //Act
            BankAccount f = new BankAccount(1444, "Patrick", startingBalance);
            f.Withdraw(100);

            //Assert
            Assert.AreEqual(expectedResult, f.Balance);
        }

        [TestMethod]
        [TestCategory("ExceptionChecking")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_NothingOrLessThanZero_Exception()
        {
            //Arrange
            double startingBalance = 50;
            double expectedResult = 0;

            //Act
            BankAccount f = new BankAccount(1444, "Patrick", startingBalance);
            f.Withdraw(0);

            //Assert
            Assert.AreEqual(expectedResult, f.Balance);
        }

        [TestMethod]
        [TestCategory("ExceptionChecking")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deposit_NothingOrLessThanZero_Exception()
        {
            //Arrange
            double startingBalance = 0;
            double expectedResult = 0;

            //Act
            BankAccount f = new BankAccount(1444, "Patrick", startingBalance);
            f.Deposit(0);

            //Assert
            Assert.AreEqual(expectedResult, f.Balance);
        }
    }
}
