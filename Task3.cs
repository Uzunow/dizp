using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
     class Task3
    {
        static void Main()
        {
            int[,,] matrix = new int[1, 3, 3];

            Console.WriteLine("Въведете 3x3 матрица:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrix[0, i, j] = int.Parse(Console.ReadLine());

            int a = matrix[0, 0, 0], b = matrix[0, 0, 1], c = matrix[0, 0, 2];
            int d = matrix[0, 1, 0], e = matrix[0, 1, 1], f = matrix[0, 1, 2];
            int g = matrix[0, 2, 0], h = matrix[0, 2, 1], i2 = matrix[0, 2, 2];

            int det = a * (e * i2 - f * h) - b * (d * i2 - f * g) + c * (d * h - e * g);
            Console.WriteLine("Детерминанта: " + det);
        }
    }
}

