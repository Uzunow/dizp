using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();
            var b = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();

            var union = a.Union(b);
            var diff = a.Except(b);
            var symDiff = a.Union(b).Except(a.Intersect(b));

            Console.WriteLine("Обединение: " + string.Join(",", union));
            Console.WriteLine("Разлика: " + string.Join(",", diff));
            Console.WriteLine("Допълнение: " + string.Join(",", symDiff));

        }
    }
}
