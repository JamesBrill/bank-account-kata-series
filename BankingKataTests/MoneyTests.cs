using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }

    public class Money
    {
        public Money(int value)
        {
            throw new NotImplementedException();
        }
    }
}
