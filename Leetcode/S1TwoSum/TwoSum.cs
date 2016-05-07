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
            for(int i = time + 1 ; i < nums.Length; i++)
            {
                if(nums[time]+ nums[i]== target)
                {
                    return new int[] { time,i};
                }
            }
            return TwoSumHelper(nums, target,time+1);
        }



    }
}