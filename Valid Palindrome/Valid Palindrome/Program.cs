using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static bool IsPalindrome(string s)
        {
            string z = "", x = "";
            int l = 0, r = s.Length - 1;
            s = s.ToLower();
            if (s == " ")
                return true;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                    z += s[i];

            }
            for (int i = z.Length - 1; i >= 0; i--)
            {

                x += z[i];

            }
            if (x.Equals(z))
                return true;
            else
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}