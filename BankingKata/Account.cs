using System;
using System.IO;

namespace BankingKata
{
    public class Account
    {
        private Money _balance;

        public void Withdraw(Money money)
        {
            _balance -= money;
        }

        public void PrintBalance(StringWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}