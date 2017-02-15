using System;

namespace _4.Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nearestStar = 4.22m;
            decimal galxy = 26000;
            decimal milkiWay = 100000;
            decimal earth = 46500000000;

            nearestStar *= 9450000000000;
            galxy *= 9450000000000;
            milkiWay *= 9450000000000;
            earth *= 9450000000000;

            Console.WriteLine(nearestStar.ToString("e2"));
            Console.WriteLine(galxy.ToString("e2"));
            Console.WriteLine(milkiWay.ToString("e2"));
            Console.WriteLine(earth.ToString("e2"));


        }
    }
}
