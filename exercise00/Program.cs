﻿using System;

namespace exercise00
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int numInput;
            Int32.TryParse(input, out numInput);
            if(Int32.TryParse(input, out numInput))
            {
                if(IsLeapYear(numInput))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            }
            else
            {
                Console.WriteLine("NaN");
            }
            
            Console.WriteLine("Hello World!");

        }

        public static bool IsLeapYear(int year)
        {
            if(year%400 == 0)
            {   
                return true;

            } 
            else if(year%100 == 0)
            {
                return false;
            } 
            else if(year%4 == 0)
            {
                return true;
            } 
            else

            } else if(year%100 == 0)
            {
                return false;
            } else if(year%4 == 0)
            {
                return true;
            } else

            {
                return false;
            }
        }

    }
}