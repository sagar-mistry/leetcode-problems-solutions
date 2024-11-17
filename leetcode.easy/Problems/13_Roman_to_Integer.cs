using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _13_Roman_to_Integer
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<string, int> romanToIntDict = new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "IV", 4 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 }
            };
            try
            {
                // Here, We'll check 2 adjacent numerals, if it exists in the dictionary
                // if XL comes, we'll take XL = 40 and skips 2 numerals
                // input = MCMXCIV
                for (int i = 0; i < s.Length; i++)
                {
                    int num;
                    string a = Convert.ToString(s[i]);
                    string b = (i + 1) > s.Length - 1 ? string.Empty : Convert.ToString(s[i + 1]);
                    string romanNumeralKey = a + b;

                    if (romanToIntDict.ContainsKey(romanNumeralKey))
                    {
                        romanToIntDict.TryGetValue(romanNumeralKey, out num);
                        i++;
                    }
                    else
                    {
                        romanNumeralKey = Convert.ToString(s[i]);
                        romanToIntDict.TryGetValue(romanNumeralKey, out num);
                    }
                    sum += num;
                }
                return sum;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}

