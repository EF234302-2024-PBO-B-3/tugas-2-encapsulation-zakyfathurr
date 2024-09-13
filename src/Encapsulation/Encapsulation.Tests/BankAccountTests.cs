using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation.Banking;

namespace Encapsulation.Tests.Banking
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void BankAccount_InitializeWithPositiveBalance_SetsBalanceCorrectly()
        {
            // Arrange
            double initialBalance = 1000.0;

            // Act
            BankAccount account = new BankAccount("12345", "John Doe", initialBalance);

            // Assert
            Assert.AreEqual(initialBalance, account.Balance);
        }

        [TestMethod]
        public void BankAccount_InitializeWithNegativeBalance_SetsBalanceToZero()
        {
            // Arrange
            double initialBalance = -1000.0;

            // Act
            BankAccount account = new BankAccount("12345", "John Doe", initialBalance);

            // Assert
            Assert.AreEqual(0.0, account.Balance);
        }

        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("12345", "John Doe", 1000.0);
            double depositAmount = 500.0;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(1500.0, account.Balance);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_DoesNotChangeBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("12345", "John Doe", 1000.0);
            double depositAmount = -500.0;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(1000.0, account.Balance);
        }

        [TestMethod]
        public void Withdraw_PositiveAmount_DecreasesBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("12345", "John Doe", 1000.0);
            double withdrawAmount = 500.0;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(500.0, account.Balance);
        }

        [TestMethod]
        public void Withdraw_MoreThanBalance_DoesNotChangeBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("12345", "John Doe", 1000.0);
            double withdrawAmount = 1500.0;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(1000.0, account.Balance);
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_DoesNotChangeBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("12345", "John Doe", 1000.0);
            double withdrawAmount = -500.0;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(1000.0, account.Balance);
        }
    }
}
