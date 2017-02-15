using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3;/// int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void  PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n-1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
            static void PrintLine(int size)
            {
                for (int i = 1; i <= size; i++)
                {
                    Console.Write(i+" ");
                }
            Console.WriteLine();
                
            
           
        
    }
}
}
