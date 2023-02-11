using System;

namespace MyApp 
{
    public class Program
    {

        public static int StrStr(string haystack, string needle)
        {
            int x=haystack.IndexOf(needle);
            return x;
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}