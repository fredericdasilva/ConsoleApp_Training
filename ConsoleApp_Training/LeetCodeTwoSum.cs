using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Training
{
    static class LeetCodeTwoSum
    {

        static public void test()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result;
            result = Method1(nums, target);
            result = Method2(nums, target);

        }

        public static int[] Method1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] {i,j };
                    }
                }
            }

            return null;

        }

        public static int[] Method2(int[] nums, int target)
        {
            Hashtable table = new Hashtable();
            table[nums[0]] = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (table.Contains(diff))
                {
                    return new int[2] { (int)table[diff], i };
                }

                var origin = target - diff;
                if (!table.Contains(origin))
                {
                    table[origin] = i;
                }
            }

            return null;

        }

    }
}
