using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class AccountTests
    {
        [Test]
        public void ShouldThrowWhenWithdrawingFromAccountIfNoDepositsMade()
        {
            var account = new Account();
            Assert.That(() => account.Withdraw(new Money(1)), Throws.InvalidOperationException);
        }

        [Test]
        public void NewAccountShouldDisplayZeroBalance()
        {
            var account = new Account();
            var writer = new StringWriter();
            account.PrintBalance(writer);

            Assert.That(writer.ToString(), Is.EqualTo("0"));
        }

        [Test]
        public void AccountShouldDisplayCorrectBalanceAfterDeposit()
        {
            var account = new Account();
            account.Deposit(new Money(1));

            var writer = new StringWriter();
            account.PrintBalance(writer);

            Assert.That(writer.ToString(), Is.EqualTo("1"));
        }
    }
}
