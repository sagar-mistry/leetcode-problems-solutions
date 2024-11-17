using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _66_Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Count() > 0)
            {
                BigInteger wholeNumber = 0;
                foreach (int n in digits)
                {
                    wholeNumber = (wholeNumber * 10) + n;
                }
                wholeNumber++;
                return wholeNumber.ToString().Select(a => int.Parse(a.ToString())).ToArray();
            }
            return digits;
        }
    }
}
