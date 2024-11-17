using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy.Problems
{
    internal class _35_Search_Insert_Position
    {
        // [1,3,5,6]
        // target=2
        public int SearchInsert(int[] nums, int target)
        {
            if (nums != null && nums.Length > 0)
            {
                int left = 0; int right = nums.Length - 1;
                while (left <= right)
                {
                    // find the middle element from the sorted array
                    int mid = left + (right - left) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return left;
            }
            return 0;
        }
    }
}
