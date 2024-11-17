using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _28_FindtheIndex_of_FirstOccurence
    {
        public int StrStr(string haystack, string needle)
        {
            try
            {
                if (haystack.IndexOf(needle) != -1)
                {
                    return haystack.IndexOf(needle);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
