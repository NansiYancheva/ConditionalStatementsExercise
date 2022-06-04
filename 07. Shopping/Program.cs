using System;
namespace Shopping
{
    class Program
    {
        static void Main()
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            //Actions
            double priceVideocards = videocards * 250;
            double priceProcessors = processors * (priceVideocards * 0.35);
            double priceRam = ram * (priceVideocards * 0.10);
            double totalPrice = priceVideocards + priceProcessors + priceRam;

            if (videocards > processors)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            if (budget >= totalPrice)
            {
                double left = Math.Abs(budget - totalPrice);
                Console.WriteLine($"You have {left:f2} leva left!");
            }
            else
            {
                double notEnough = Math.Abs(totalPrice - budget);
                Console.WriteLine($"Not enough money! You need {notEnough:f2} leva more!");
            }
            //Output
        }
    }
}
