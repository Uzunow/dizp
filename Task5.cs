using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task5
    {
        static void Main()
        {
            Console.Write("Брой вектори: ");
            int n = int.Parse(Console.ReadLine());

            double minLength = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Вектор {i + 1} (x y z): ");
                double[] v = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double length = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
                if (length < minLength) minLength = length;
            }

            Console.WriteLine($"Най-къс вектор има дължина: {minLength:F2}");
        }
    }

}

