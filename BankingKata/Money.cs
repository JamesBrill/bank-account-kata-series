using System;

namespace BankingKata
{
    public class Money
    {
        public Money(int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException("value", value, "Value must be non-negative");
        }
    }
}