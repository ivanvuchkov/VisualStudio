using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            var n=Math.Abs(int.Parse(Console.ReadLine()));
            var result = MultipeOfEventandOddDigits(n);

            Console.WriteLine(result);
            
        }

       private static long MultipeOfEventandOddDigits(int n)
        {
            var sumEvent = EventDigits(n);
            var sumOdd = OddDigits(n);
            return sumEvent * sumOdd;
        }
        static int EventDigits(int n)
        {
           
                int sum = 0;
                while (n > 0)
                {
                    int lastDigits = n % 10;
                    if(lastDigits % 2 != 0)
                    {
                        sum +=lastDigits;
                    
                    
                }
                    n /= 10;

            }
                return sum;
        }
        static int OddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
               int lastDigits = n % 10;
                if(!(lastDigits % 2 != 0))
                {
                    sum+=lastDigits;
                    
                }
                n /= 10;
            }
            return sum;

        }

    }
    }


