using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber =int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;

            }
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                sum += numbers[i];

            }
            Console.WriteLine(sum);
            
         
        }
    }
}
