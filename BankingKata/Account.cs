using System;

namespace BankingKata
{
    public class Account
    {
        private Money _balance;

        public void Withdraw(Money money)
        {
            _balance -= money;
        }
    }
}