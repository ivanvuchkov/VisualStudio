using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string lastWord=words.Last();
            string firstWord = words.First();

            if (lastWord == firstWord)
            {
                Console.WriteLine("Yes");
            }else
                Console.WriteLine("No");    
        }
    }
}
