using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coeffs = Console.ReadLine().Split(',').Select(double.Parse).ToArray();
            double x = double.Parse(Console.ReadLine());

            double result = 0;
            for (int i = 0; i < coeffs.Length; i++)
                result += coeffs[i] * Math.Pow(x, coeffs.Length - i - 1);

            Console.WriteLine(result == 0 ? "Корен е" : "Не е корен");

        }
    }
}
