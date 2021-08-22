using System;

namespace TwoSum
{
    class Program
    {

        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        //Example 1:
        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        //Example 2:
        //Input: nums = [3, 2, 4], target = 6
        //Output: [1,2]
        //Example 3:
        //Input: nums = [3, 3], target = 6
        //Output: [0,1]

        //Input [3,2,3]  6
        // Output [0, 0] Expected [0, 2]

        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 3 };
            int target = 6;
            // TwoSum(nums, target);
            TwoSumAny(nums, target);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i]+ nums[i + 1] == target)
                {
                    result[0] = i;
                    result[1] = i + 1;
                }
            }
            return result;
        }

        public static int[] TwoSumAny(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length-i; j++)
                {
                    if (nums[i]+nums[j+i] == target)
                    {
                        result[0] = i;
                        result[1] = j + i;
                        return result;
                    }
                }


            }
            return result;
        }
    }
}
