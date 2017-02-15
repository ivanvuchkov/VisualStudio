using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int asciiCode= int.Parse(Console.ReadLine());
                char charakter = (char) asciiCode;
                result += charakter;
                
            }
            Console.WriteLine(result);

        }
    }
}
