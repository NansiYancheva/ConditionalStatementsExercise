using System;
namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main()
        {
            //Input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());
            //Actions
            double timeForSwimming = meters * timeInSecondsForOneMeter;
            double slowerSwimming = Math.Floor(meters / 15) * 12.5;
            double totalTimeForSwimming = (timeForSwimming + slowerSwimming);
            if (recordInSeconds > totalTimeForSwimming)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeForSwimming:f2} seconds.");
            }
            else
            {
                double neededTimeToBeatTheRecord = totalTimeForSwimming - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededTimeToBeatTheRecord:f2} seconds slower.");
            }
            //Output
        }
    }
}

