﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public  bool IsPalindrome(int x)
        {
            var y=x.ToString();
            y.Reverse();

            return x.ToString()==y;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine();
        }
    }
}