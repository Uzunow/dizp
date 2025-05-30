using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task7
    {
        static long Factorial(int n)
        {
            long f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            return f;
        }

        static void Main()
        {
            Console.Write("Въведете n и k: ");
            string[] parts = Console.ReadLine().Split();
            int n = int.Parse(parts[0]);
            int k = int.Parse(parts[1]);

            long perm = Factorial(n);
            long comb = Factorial(n) / (Factorial(k) * Factorial(n - k));
            long var = Factorial(n) / Factorial(n - k);

            Console.WriteLine($"Пермутации: {perm}");
            Console.WriteLine($"Комбинации: {comb}");
            Console.WriteLine($"Вариации: {var}");
        }
    }

}

