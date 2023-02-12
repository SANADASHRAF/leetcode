using System;
using System.Text;

namespace MyApp
{
    public class Program
    {
        public static String ReverseWords(String s)
        {
           
            {
                return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Program.ReverseWords("the   sky is blue"));
           
        }
    }
}