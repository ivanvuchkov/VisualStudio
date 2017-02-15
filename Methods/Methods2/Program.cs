using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine(@"/\----/\----/\");
        }
        static void PrintBody()
        {
            Console.WriteLine(@"||----||----||");
        }
        static void PrintFooter()
        {
            Console.WriteLine(@"\/----\/----\/");
        }
    }
}
