using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            AllofThis(n);
        }

        private static void AllofThis(int n)
        {
            PrintHead(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }

            PrintHead(n);
        }

        static void PrintBody(int n)
        {
            var body ="-";

            for (int i = 0; i < n-1; i++)
            {
                body += @"\/";
            }
            body += "-";
            Console.WriteLine(body); 
        }
        static void PrintHead(int n)
        {
            var header = new string('-', n * 2);
            Console.WriteLine(header);
        }

    }
}
