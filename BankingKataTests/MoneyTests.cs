using System;
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

        [Test]
        public void SumOfMoniesShouldEqualSum()
        {
            var first = new Money(1);
            var second = new Money(2);

            var sum = first + second;
            Assert.AreEqual(new Money(3), sum);
        }

        [Test]
        public void SubtractingMoniesGivesDifference()
        {
            var first = new Money(3);
            var second = new Money(2);

            var difference = first - second;
            Assert.AreEqual(new Money(1), difference);
        }
    }
}