using System;


namespace _03.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

             int temp = a;
            a = b;
            b = temp;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
