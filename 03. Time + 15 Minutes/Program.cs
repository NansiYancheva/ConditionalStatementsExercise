using System;
namespace TimeMinutes
{
    class Program
    {
        static void Main()
        {
            //Input
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //Actions
            minutes += 15;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            //Output
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
