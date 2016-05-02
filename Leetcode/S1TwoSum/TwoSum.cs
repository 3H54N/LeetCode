using System;
using System.Collections.Generic;

namespace S1TwoSum
{
    public class LeetCodeTwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {            
            return TwoSumHelper(nums, target,0);

        }

        private int[] TwoSumHelper(int[] nums, int target,int time)
        {
            int[] result = { 0,0};
            result[0] = time;
            for(int i = time + 1 ; i < nums.Length; i++)
            {
                if(nums[time]+ nums[i]== target)
                {
                    result[1] = i;
                    return result;
                }
            }
            return TwoSumHelper(nums, target,time+1);
        }



    }
}