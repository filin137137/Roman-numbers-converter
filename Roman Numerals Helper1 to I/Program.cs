﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Helper1_to_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            bool work = true;
            Console.WriteLine("Hi");
            while (work)
            {
                Console.WriteLine("Enter a number");
                int n = Int32.Parse(Console.ReadLine());

                //Main code
                int n2 = n;
                string String = "";
                int[] roman = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                while (n != 0)
                {
                    for (int j = 0; j < arab.Length; j++)
                    {
                        if (n >= roman[j]) { String += arab[j]; n -= roman[j]; break; }
                    }
                    //Console.WriteLine($"{String}  =  {n} ");
                }
                Console.WriteLine($"{String} = {n2}");

            //Do it next time one more time
            AnotherTry:
                Console.WriteLine("Let's repeat ? \n Write Yes/No ");
                string Repeat = Console.ReadLine();
                switch (Repeat)
                {
                    case "No": work = false; break;
                    case "Yes": work = true; break;
                    default:
                        Console.WriteLine("Please, write the right word");
                        goto AnotherTry;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
