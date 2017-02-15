using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEBUGG
{
    class Program
    {
        static void Main(string[] args)
        {
                 string delimiter = Console.ReadLine();
                var numberOfStrings = int.Parse(Console.ReadLine());
                
                var result = string.Empty;
                var currentString = string.Empty;

            for (int i = 0; i <= numberOfStrings; i++)
            {
                    currentString = Console.ReadLine();

                    result += currentString + delimiter;
                if (i == numberOfStrings - 1)
                {

                    var result += currentString;
                }
            }
            
            Console.WriteLine(result);
        }
        
            
        }
        }
    
