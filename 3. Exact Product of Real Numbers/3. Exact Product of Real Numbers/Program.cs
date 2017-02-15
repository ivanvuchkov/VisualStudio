using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numbers = ulong.Parse(Console.ReadLine());

            decimal sum = 0;
            for (ulong i = 0; i < numbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
