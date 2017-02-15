using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 4;
            var numSquere = GetSquere(num);
            Console.WriteLine(numSquere);
        }
        static double GetSquere(double number)
        {
            var result = number * number;
            return result;
        }
    }
}
