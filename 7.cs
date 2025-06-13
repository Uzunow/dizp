using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();
            var b = Console.ReadLine().Split(',').Select(int.Parse).ToHashSet();

            Console.WriteLine("Сечение: " + string.Join(",", a.Intersect(b)));
            Console.WriteLine("Обединение: " + string.Join(",", a.Union(b)));
            Console.WriteLine("Разлика: " + string.Join(",", a.Except(b)));

        }
    }
}
