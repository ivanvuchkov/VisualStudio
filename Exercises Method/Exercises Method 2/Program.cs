using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 =int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(MinNumber(num1,num2,num3));


        }

        static int MinNumber(int num1,int num2,int num3)
        {
            int min = Math.Min(num1, num2);
            if (min < num3)
            {
                min=min;
            }
            else if (min>num3)
                min=num3;
            
            return min;
            

        }
    }
}
