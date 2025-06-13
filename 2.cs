using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(',').Select(double.Parse).ToList();

            double average = numbers.Average();
            double mode = numbers.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
            double median = numbers.OrderBy(x => x).ElementAt(numbers.Count / 2);

            Console.WriteLine($"Средна: {average}, Мода: {mode}, Медиана: {median}");

        }
    }
}
