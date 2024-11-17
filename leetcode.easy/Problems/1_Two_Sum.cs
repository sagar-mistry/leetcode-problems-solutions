using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetcode.easy.Problems
{

    //    Code
    //    Testcase
    //Testcase
    //Test Result
    //1. Two Sum
    //Attempted
    //Easy
    //Topics
    //Companies
    //Hint
    //    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //You can return the answer in any order.




    //Example 1:

    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:

    //Input: nums = [3, 2, 4], target = 6
    //Output: [1,2]
    //Example 3:

    //Input: nums = [3, 3], target = 6
    //Output: [0,1]


    //Constraints:

    //2 <= nums.length <= 104
    //-109 <= nums[i] <= 109
    //-109 <= target <= 109
    //Only one valid answer exists.
    public class _1_Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        break;
                    }
                }
            }
            return output;
        }
    }
}
