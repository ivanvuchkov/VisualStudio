using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte varable = 0;
            int times = 0;

            for (int i = 0; i < n; i++)
            {
                varable++;
                if (varable==0)
                {
                    times++;

                }
              
            }
            Console.WriteLine(varable);
            Console.WriteLine("Overflowed {0} times", times);


        }
    }
} 
