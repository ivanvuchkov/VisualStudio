using System;

namespace oopas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int minimum = MinNumber(num1, num2,num3);
            Console.WriteLine(minimum);
        }

        static int MinNumber(int num1, int num2, int num3)
        {
            int min = Math.Min(num1, num2);
            if (min < num3)
            {
                return min; ;
            }
            else if (min > num3)
                min = num3;
            return min;
           
        }
    }
}

