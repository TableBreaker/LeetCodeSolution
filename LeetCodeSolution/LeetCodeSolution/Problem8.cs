using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem8 : Problem
    {
        public override void Execute()
        {
            Console.WriteLine(MyAtoi("+132"));
        }

        public int MyAtoi(string str)
        {
            int sign = 1;
            int baseX = 0;
            int i = 0;
            if (str.Length <= 0) return 0;
            str = str.Trim();
            if (str[i] == '-' || str[i] == '+')
            {
                sign = 1 - 2 * (str[i++] == '-' ? 1 : 0);
            }
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (baseX > Int32.MaxValue / 10 || (baseX == Int32.MaxValue / 10 && str[i] - '0' > 7))
                {
                    if (sign == 1) return Int32.MaxValue;
                    else return Int32.MinValue;
                }
                baseX = 10 * baseX + (str[i++] - '0');
            }
            return baseX * sign;
        }
    }
}
