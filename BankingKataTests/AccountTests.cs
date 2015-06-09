using System.Collections.Generic;
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
    }
}
