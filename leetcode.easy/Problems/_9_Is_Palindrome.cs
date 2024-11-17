using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _9_Is_Palindrome
    {
        //Another way- use stack
        //Keep adding all the chars in the stack, start popooing all 
        //Compare before & after
        public static bool IsPalindrome(int num)
        {
            bool result = true;
            try
            {
                char[] numsArray = Convert.ToString(num).ToArray();
                int j = numsArray.Length - 1;
                for (int i = 0; i < numsArray.Length; i++)
                {
                    if (i == j)
                    {
                        return result;
                    }
                    if (numsArray[i] != numsArray[j])
                    {
                        result = false;
                        break;
                    }
                    else
                    {
                        result = true;
                    }
                    j--;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result;
            }
        }
    }
}
