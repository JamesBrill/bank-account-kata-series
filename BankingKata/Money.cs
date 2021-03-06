﻿using System;

namespace BankingKata
{
    public struct Money : IEquatable<Money>
    {
        private readonly int _value;

        public Money(int value)
        {
            _value = value;
            if (value < 0) throw new ArgumentOutOfRangeException("value", value, "Value must be non-negative");
        }

        public bool Equals(Money other)
        {
            return _value == other._value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Money) obj);
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static bool operator ==(Money left, Money right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !Equals(left, right);
        }

        public static Money operator +(Money left, Money right)
        {
            return new Money(left._value + right._value);
        }

        public static Money operator -(Money left, Money right)
        {
            var difference = left._value - right._value;
            if (difference < 0)
            {
                throw new InvalidOperationException();
            }
            return new Money(difference);
        }
    }
}