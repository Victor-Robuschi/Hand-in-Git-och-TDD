using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDD;

namespace TDDtest1
{
    public class BankAccountTest
    {
        [Fact]
        public void ShouldReturnTrue_ForCorrectWithdraw()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            //Act
            bool result = bankAccount.Withdraw(100);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void ShouldReturnFalse_ForIncorrectWithdraw()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bool result = bankAccount.Withdraw(100);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ShouldReturnFalse_ForNegativeAmountWithdraw()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bool result = bankAccount.Withdraw(-100);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ShouldReturnTrue_ForCorrectBalanceAfterWithdraw()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);
            //Assert
            Assert.Equal(50, bankAccount.GetBalance());
        }
        [Fact]
        public void ShouldReturnTrue_ForCorrectDeposit()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bool result = bankAccount.Deposit(100);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void ShouldReturnFalse_ForNegativeAmountDeposit()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bool result = bankAccount.Deposit(-100);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ShouldReturnTrue_ForCorrectBalanceAfterDeposit()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            //Act
            bankAccount.Deposit(100);
            //Assert
            Assert.Equal(100, bankAccount.GetBalance());
        }
    }
}
