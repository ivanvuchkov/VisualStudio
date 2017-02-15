using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6taMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());
            var conver = IntigerBase(number,toBase);
            Console.WriteLine(conver);

        }
        static string IntigerBase(int number , int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder+result;
                number /= toBase;
            }
            return result;
        }

    }
}
