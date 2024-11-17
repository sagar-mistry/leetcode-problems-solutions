using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _14_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string longestCommonPrefix = string.Empty;
            if (strs.Length > 1 && strs.Length <= 200)
            {
                string prefix = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    while (!strs[i].StartsWith(prefix))
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                    }
                    longestCommonPrefix = prefix;
                }
            }
            else if (strs.Length == 1)
            {
                longestCommonPrefix = strs[0];
            }
            return longestCommonPrefix;
        }
    }
}
