using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _58_Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                s = s.Trim();
                var strings = s.Split(' ');
                if (strings.Length > 0)
                {
                    return strings[strings.Length - 1].Length;
                }
                else
                {
                    return strings[0].Length;
                }
            }
            return 0;
        }
    }
}
