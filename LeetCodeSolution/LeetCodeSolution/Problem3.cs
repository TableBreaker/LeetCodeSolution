using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem3 : Problem
    {
        public override void Execute()
        {
            var s = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(s));
        }

        public int LengthOfLongestSubstring(string s)
        {
            var arr = s.ToCharArray();
            var dpList = new List<char>();
            var maxLength = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var c = arr[i];
                if (dpList.Contains(c))
                {
                    var index = dpList.IndexOf(c);
                    dpList.RemoveRange(0, index + 1);
                }
                dpList.Add(c);
                if (dpList.Count > maxLength)
                    maxLength = dpList.Count;
            }
            return maxLength;
        }
    }
}
