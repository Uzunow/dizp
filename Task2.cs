using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task2
    {
        static void Main()
        {
            Console.Write("Въведете числа, разделени с интервал: ");
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double average = numbers.Average();
            double median = numbers.OrderBy(n => n).ElementAt(numbers.Length / 2);
            double mode = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;

            Console.WriteLine($"Средно: {average:F2}, Медиана: {median}, Мода: {mode}");
        }
    }
}

