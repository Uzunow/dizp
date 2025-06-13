using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число: ");
            string input = Console.ReadLine();
            Console.WriteLine("Начална бройна система: ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Крайна бройна система: ");
            int toBase = int.Parse(Console.ReadLine());

            int decimalValue = Convert.ToInt32(input, fromBase);
            string result = Convert.ToString(decimalValue, toBase).ToUpper();
            Console.WriteLine($"Резултат: {result}");

        }
    }
}
