using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem7 : Problem
    {
        public override void Execute()
        {
            Console.WriteLine(Reverse(-123));
        }

        public int Reverse(int x)
        {
            var arr = x < 0 ? (-x).ToString().ToCharArray() : x.ToString().ToCharArray();
            var arrInv = new char[arr.Length];
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                arrInv[arr.Length - 1 - i] = arr[i];
            }

            if (int.TryParse((x < 0 ? "-" : "") + new string(arrInv), out x))
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
    }
}
