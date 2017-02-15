using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 4.5;
            var  numSqared=GetSquere(num);
            Console.WriteLine(numSqared);
        }
        static double GetSquere(double number)
        {
            var result = number * number;
            return result;
        }
    }
}
