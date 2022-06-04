using System;
namespace GodzillaKong
{
    class Program
    {
        static void Main()
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int statistNumbers = int.Parse(Console.ReadLine());
            double dressPricePerOneStatist = double.Parse(Console.ReadLine());
            double dressTotalPrice = statistNumbers * dressPricePerOneStatist;
            //Actions
            double decorPrices = budget * 0.10;
            if (statistNumbers > 150)
            {
                double discountDress = dressTotalPrice * 0.10;
                dressTotalPrice -= discountDress;
            }
            double totalExpenses = dressTotalPrice + decorPrices;
            if (totalExpenses > budget)
            {
                double notEnoughMoney = totalExpenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {notEnoughMoney:f2} leva more.");
            }
            else if (totalExpenses <= budget)
            {
                double extraMoney = budget - totalExpenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {extraMoney:f2} leva left."
);
            }

        }
    }
}

