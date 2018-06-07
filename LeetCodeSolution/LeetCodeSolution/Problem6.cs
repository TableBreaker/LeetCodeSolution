using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem6 : Problem
    {
        public override void Execute()
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
        }

        public string Convert(string s, int numRows)
        {
            if (numRows <= 1 || string.IsNullOrEmpty(s))
                return s;

            var zig = 2 * numRows - 2;
            var col = s.Length / zig;
            var remain = s.Length % zig;
            col *= numRows - 1;
            if (remain <= numRows)
                col++;
            else if (remain > numRows)
                col += 1 + remain - numRows;
            var matrix = new char[col, numRows];

            var arr = s.ToCharArray();
            for (var i = 0; i < arr.Length; i++)
            {
                var pos = i + 1;
                var x = pos / zig * (numRows - 1);
                var rm = pos % zig;
                var y = 1;

                if (rm == 0)
                {
                    rm = zig;
                    y = 2 * numRows - rm;
                }
                else if (rm <= numRows)
                {
                    x++;
                    y = rm;
                }
                else
                {
                    x += 1 + rm - numRows;
                    y = 2 * numRows - rm;
                }


                matrix[x - 1, y - 1] = arr[i];
            }

            var bd = new StringBuilder();
            for (var i = 0; i < numRows; i++)
                for (var j = 0; j < col; j++)
                {
                    if (matrix[j, i] == 0) continue;
                    bd.Append(matrix[j, i]);
                }
            return bd.ToString();
        }
    }
}
