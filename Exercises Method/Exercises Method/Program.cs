using System;

namespace Exercises_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(NameOfPerson(name));
        }
        static string NameOfPerson(string name)
        {
            string hallo = "Hello, " + name +"!";
            return hallo;

        }
    }
}
  