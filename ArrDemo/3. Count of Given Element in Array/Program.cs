﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int p = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
            
                if (arr[i] == p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);



        }
    }
}
