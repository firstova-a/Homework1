using System;
using System.Collections.Generic;
using System.IO;
namespace average_and_variance
{
    class Program
    {
        static void Main(string[] args)
        {
            string File = args[0];
            var sr = new StreamReader(File);
            List<string> num = new List<string>(sr.ReadToEnd().Split("\r\n"));
            double sum = 0; double count = 0;
            num.Remove("");
            foreach(string n in num)
            {
                sum += double.Parse(n);
                count++;
            }
            double average = sum / count;
            double buf = 0;
            foreach (string n in num)
            {
                buf += Math.Pow((double.Parse(n)- average), 2);
            }
            double variance =buf / count;
            Console.WriteLine("Среднее арифметическое: " + average);
            Console.WriteLine("Дисперсия:              " + variance);
            Console.ReadLine();
        }
    }
}
