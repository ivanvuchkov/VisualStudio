using System;


namespace oooop3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(name,number));

        }
        static string RepeatString(string name, int number)
        {
            string repeatedString = name;
            for (int i = 1; i < number; i++)
            {
                Console.Write(repeatedString,number);
            }
            return repeatedString;
        }
    }
}
