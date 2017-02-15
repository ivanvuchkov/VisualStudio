using System;
using System.Linq;

namespace _1.Largest_Element_in_Array
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            var max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = int.Parse(Console.ReadLine());
                numbers[i] = currentNumbers;
                max = numbers.Max();

            }
            Console.WriteLine(max);
                
        }
    }
}
