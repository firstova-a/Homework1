using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime pr = DateTime.Now;
            Console.WriteLine($"Текущий день недели: {(int) pr.DayOfWeek} ({pr.DayOfWeek})");
            Console.WriteLine($"Текущее время: {pr:HH:mm:ss}");
            Console.ReadLine();
        }
    }
}
