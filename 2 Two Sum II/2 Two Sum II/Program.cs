using System;

namespace MyApp 
{

    public class Program
    {

        public int[] TwoSum(int[] numbers, int target)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int j = BinarySearch(numbers, target - numbers[i]);
                if (j == i)
                    return new int[] { i + 1, j + 2 };
                if (j != -1)
                {
                    return new int[] { i + 1, j + 1 };
                }
            }
            return null;
        }
        public int BinarySearch(int[] nums, int key)
        {
            int first = 1;
            int last = nums.Length - 1;
            int mid = 0;
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] < key)
                    first = mid + 1;
                else
                    last = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}