using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void Permute(int[] arr, int k = 0)
            {
                if (k == arr.Length)
                    Console.WriteLine(string.Join(",", arr));
                else
                    for (int i = k; i < arr.Length; i++)
                    {
                        (arr[k], arr[i]) = (arr[i], arr[k]);
                        Permute(arr, k + 1);
                        (arr[k], arr[i]) = (arr[i], arr[k]);
                    }
            }

            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Permute(nums);

        }
    }
}
