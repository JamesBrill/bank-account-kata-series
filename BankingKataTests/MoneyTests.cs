using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class MoneyTests
    {
        [Test]
        public void ShouldNotCreateNegativeMoney()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Money(-1));
        }

        [Test]
        public void TwoZeroMoniesShouldBeEqual()
        {
            Assert.AreEqual(new Money(0), new Money(0));
        }
    }
}
