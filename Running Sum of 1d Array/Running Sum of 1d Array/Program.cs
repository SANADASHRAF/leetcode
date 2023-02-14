using System;

namespace MyApp 
{
    internal class Program
    {
        public int[] RunningSum(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            prefix[0] = nums[0];
            for(int i = 1; i < nums.Length; i++)
             {
                prefix[i]=prefix[i-1]+nums[i];
             }
            return prefix;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}