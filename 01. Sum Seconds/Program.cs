using System;
namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            //Input
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            //Actions
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
