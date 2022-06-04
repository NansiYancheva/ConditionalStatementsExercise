using System;
namespace LunchBreak
{
    class Program
    {
        static void Main()
        {
            //Input
            string nameOfSeries = Console.ReadLine();
            double timePerSeria = double.Parse(Console.ReadLine());
            double timeForBreak = double.Parse(Console.ReadLine());
            //Actions
            double timeForLunch = timeForBreak / 8;
            double timeForRest = timeForBreak / 4;
            double totalLeftTime = timeForBreak - timeForLunch - timeForRest;
            //Output
            if (totalLeftTime >= timePerSeria)
            {
                double evenMoreTime = Math.Ceiling(totalLeftTime - timePerSeria);
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {evenMoreTime} minutes free time.");
            }
            else
            {
                double notEnoughTime = Math.Ceiling(timePerSeria - totalLeftTime);
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {notEnoughTime} more minutes.");
            }
        }
    }
}

