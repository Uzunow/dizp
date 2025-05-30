using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task6
    {
        static void Main()
        {
            Console.Write("Множество A: ");
            var A = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            Console.Write("Множество B: ");
            var B = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            var union = A.Union(B);
            var intersect = A.Intersect(B);
            var difference = A.Except(B);

            Console.WriteLine("Обединение: " + string.Join(" ", union));
            Console.WriteLine("Сечение: " + string.Join(" ", intersect));
            Console.WriteLine("Разлика (A - B): " + string.Join(" ", difference));
        }
    }
}

