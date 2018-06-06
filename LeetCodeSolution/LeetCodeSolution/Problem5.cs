using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem5 : Problem
    {
        public override void Execute()
        {
            Console.WriteLine(LongestPalindrome("babad"));
        }

        public string LongestPalindrome(string s)
        {
            if (s == null) return null;

            var arr = s.ToCharArray();
            var maxLen = 0;
            var maxStr = "";

            // odd
            for (var i = 0; i < arr.Length; i++)
            {
                var currLen = 1;
                var offset = 0;
                while (i - offset - 1 >= 0 && i + offset + 1 <= arr.Length - 1 && arr[i - offset - 1] == arr[i + offset + 1])
                {
                    currLen += 2;
                    offset++;
                }
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxStr = s.Substring(i - offset, currLen);
                }
            }

            // even
            for (var i = 0; i < arr.Length - 1; i++)
            {
                var currLen = 0;
                var offset = 0;
                while (i - offset >= 0 && i + offset + 1 <= arr.Length - 1 && arr[i - offset] == arr[i + offset + 1])
                {
                    currLen += 2;
                    offset++;
                }
                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxStr = s.Substring(i - offset + 1, currLen);
                }
            }
            return maxStr;
        }
    }
}
