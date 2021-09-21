using Currency.Helper;
using System;

namespace Currency
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Price of products in £ : ");
            var purchaseAmount = Convert.ToDecimal(Console.ReadLine());

        start:
            Console.WriteLine("Given currency amount in £ : ");
            var givenCurrency = Convert.ToDecimal(Console.ReadLine());

            var balance = givenCurrency - purchaseAmount;

            switch (balance)
            {
                case < 0:
                    Console.WriteLine("Given amount is not enough!");
                    goto start;
                case 0:
                    Console.WriteLine("No balance amount.");
                    break;
                default:
                    {
                        var amount = new Amount(balance);
                        amount.PrintChange();
                        break;
                    }
            }
        }
    }
}
