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
            for (var i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                var diff = target - val;
                if (hash.ContainsKey(diff))
                {
                    var tarIndex = hash[diff];
                    var left = i < tarIndex ? i : tarIndex;
                    var right = i >= tarIndex ? i : tarIndex;
                    return new int[] { left, right };
                }
                hash[val] = i;
            }
            return null;
        }
    }
}
