using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(',').Select(double.Parse);

            foreach (var num in numbers)
                Console.WriteLine($"√{num} = {Math.Sqrt(num):F3}");

        }
    }
}
