using System;


namespace _7.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double tearabytes = double.Parse(Console.ReadLine());

            ulong bytes = 8796093022208;
            
            Console.WriteLine(tearabytes*bytes);
        }
    }
}
