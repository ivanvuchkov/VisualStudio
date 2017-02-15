using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int cauntIndex = 0;
            int countNumber = 0;

            for (int i = 0; i <numbers.Length; i++)
            {
                if (i % 2 != 0 && numbers[i] % 2 != 0)
            {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
            }
            }
        }
    }
}
