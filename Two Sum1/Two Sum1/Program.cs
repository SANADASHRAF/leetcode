using System;

namespace MyApp 
{
    
    public class Program
    {
        public  int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                if (dictionary.ContainsKey(target - x))
                {
                    return new int[] { dictionary[target - x], i };
                }
                dictionary[x] = i;
            }
            return null;
        }

       

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int t = 9;
            
          Console.WriteLine(  );
        }
    }
}