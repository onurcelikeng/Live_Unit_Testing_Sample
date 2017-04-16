using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankTest
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void AccountTest()
        {
            var balance = 12.12;
            var account = new Account("test", balance);
            Assert.AreEqual(balance, account.getBalance);
        }

        [TestMethod]
        public void WithDrawTest()
        {
            double currentBalance = 10.0;
            double withDrawal = 1.0;
            double expected = 9.0;

            var account = new Account("test", currentBalance);
            account.WithDraw(withDrawal);
            double actual = account.getBalance;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WithDrawExceedTest()
        {
            double currenBalance = 10.0;
            double withDrawal = 12.0;

            var account = new Account("test", currenBalance);
            Assert.ThrowsException<ArgumentException>(() => account.WithDraw(currenBalance));
        }
    }
}