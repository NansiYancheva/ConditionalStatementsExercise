using System;
namespace ToyShop
{
    class Program
    {
        static void Main()
        {
            //Input
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine()); 
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzles = puzzles * 2.60;
            double priceDolls = dolls * 3;
            double priceBears = bears * 4.10;
            double priceMinions = minions * 8.20;
            double priceTrucks = trucks * 2;

            double totalToysPrice = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;
            int totalToysCount = puzzles + dolls + bears + minions + trucks;
        
            if (totalToysCount >= 50)
            {
            double  discount = totalToysPrice * 0.25;
            totalToysPrice -= discount;
            }
            double rent = totalToysPrice * 0.10;
            totalToysPrice -=rent;
            double moneyLeft = totalToysPrice - priceExcursion;
            double moneyNeeded = priceExcursion - totalToysPrice;
            //Output
            if (totalToysPrice >= priceExcursion)
            {
                
                Console.WriteLine($"Yes! {moneyLeft :f2} lv left.");
            }
            else
            {
               
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

        }
    }
}

