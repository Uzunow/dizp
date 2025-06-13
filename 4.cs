using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var v = Console.ReadLine().Split(',').Select(double.Parse).ToArray();
                if (v[0] > 0 && v[1] > 0 && v[2] > 0) count++;
            }
            Console.WriteLine($"Брой: {count}");

        }
    }
}
