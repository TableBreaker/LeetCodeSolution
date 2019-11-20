using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem1 : Problem
    {
        public override void Execute()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var res = TwoSum(nums, target);
            if (res != null)
            {
                foreach (var i in res)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();
            int diff, i, length;
            for (i = 0, length = nums.Length; i < length; i++)
            {
                var val = nums[i];
                diff = target - val;
                if (hash.ContainsKey(diff))
                {
                    return new int[] { hash[diff], i };
                }
                hash[val] = i;
            }
            return null;
        }
    }
}
