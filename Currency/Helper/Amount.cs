using Currency.Interface;
using System;

namespace Currency.Helper
{
    /// <inheritdoc cref="IAmount"/>
    public class Amount : IAmount
    {
        private static readonly decimal[] denominations = { 50m, 20m, 10m, 5m, 2m, 1m, .5m, .2m, .1m, 0.05m, 0.02m, 0.01m };
        private static readonly string[] values = { "£50", "£20", "£10", "£5", "£2", "£1", "50p", "20p", "10p", "5p", "2p", "1p" };
        private static readonly int[] denominationCount = new int[15];
        private readonly decimal balanceAmount;

        /// <summary>
        /// Initialises new intance of the <see cref="Amount"/> 
        /// </summary>
        /// <param name="amount"> amount </param>
        public Amount(decimal amount)
        {
            balanceAmount = amount;
            for (int i = 0; i < denominations.Length; i++)
            {
                var count = (int)(amount / denominations[i]);
                denominationCount[i] = count;
                amount -= count * denominations[i];
            }
        }

        /// <inheritdoc cref="IAmount.PrintChange"/>
        public void PrintChange()
        {
            Console.WriteLine($"Your balance is £{balanceAmount} and change is: ");

            for (int i = 0; i < denominationCount.Length; i++)
                if (denominationCount[i] > 0)
                    Console.WriteLine($" {denominationCount[i]} X {values[i]}");
        }
    }
}
