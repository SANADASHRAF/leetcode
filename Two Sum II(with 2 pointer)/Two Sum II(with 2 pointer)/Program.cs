using System;

namespace MyApp 
{
    public class Program
    {

        public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;
            for (int i = 1; i <= numbers.Length; i++)
            {
                if (numbers[l] + numbers[r] == target) return new int[] { l + 1, r + 1 };
                else if (numbers[l] + numbers[r] < target) l++;
                else r--;
            }
            return null;
        }
        static void Main(string[] args)
        {

           
           
            Console.WriteLine();

        }
    }
}