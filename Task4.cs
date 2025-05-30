using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task4
    {
        static void Main()
        {
            Console.Write("Въведете коефициенти на квадратен полином (a b c): ");
            string[] parts = Console.ReadLine().Split();
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);
            double c = double.Parse(parts[2]);

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Корени: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Двоен корен: x = {x}");
            }
            else
            {
                Console.WriteLine("Няма реални корени.");
            }
        }
    }
}

