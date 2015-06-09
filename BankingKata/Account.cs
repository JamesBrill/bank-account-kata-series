using System;
using System.IO;

namespace BankingKata
{
    public class Account
    {
        private Money _balance;

        public void Deposit(Money money)
        {
            _balance += money;
        }

        public void Withdraw(Money money)
        {
            _balance -= money;
        }

        public void PrintBalance(TextWriter writer)
        {
            writer.Write(_balance);
        }
    }
}