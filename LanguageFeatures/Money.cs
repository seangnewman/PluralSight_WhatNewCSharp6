using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LanguageFeatures
{
    public struct  Money 
    {
        public Money(decimal amount, string currency)  
        {
            Amount = amount;
            Currency = Check.ArgNotNull("currency", currency);
        }

        public Money(int amount):this(amount, "eur")
        {

        }


        public static Money Parse(string input)
        {
            var parts = input.Split(' ');
            var currency = parts[1];
            decimal amount = 0;
            decimal.TryParse(parts[0], out amount);
            

            return new Money(amount, currency);
        }

        public static Money operator +(Money m1, Money m2)
        {
            if ( (string.Compare(m1.Currency, m2.Currency, StringComparison.InvariantCultureIgnoreCase)  != 0) )
            {
                var template = "Cannot add currency {0} to currency {1}";
                var message = String.Format(template, m1.Currency, m2.Currency);
                throw new InvalidOperationException(message);
            }
            return new Money(m1.Amount + m2.Amount, m1.Currency);
        }

        public decimal Amount { get; }
        public string Currency { get;  }
    }
}
