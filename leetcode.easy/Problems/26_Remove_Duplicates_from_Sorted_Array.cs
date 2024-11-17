using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _26_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> sortedList = new List<int>();
            List<int> duplicateList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!sortedList.Contains(nums[i]))
                {
                    sortedList.Add(nums[i]);
                }
                else
                {
                    duplicateList.Add(-1);
                }
            }
            int k = sortedList.Count;
            sortedList.AddRange(duplicateList);
            nums= sortedList.ToArray();
            return k;
        }
    }
}
