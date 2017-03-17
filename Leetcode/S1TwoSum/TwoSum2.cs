using System;
using System.Collections.Generic;

namespace S1TwoSum
{
    public class LeetCodeTwoSum2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // return TwoSumHelper(nums, target,0);

            IDictionary<int, int> dictNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (dictNums.ContainsKey(target - nums[i]))
                {
                    return new int[] { dictNums[target - nums[i]], i };
                }

                if (!dictNums.ContainsKey(nums[i]))
                {
                    dictNums.Add(nums[i], i);
                }   

                
            }

            throw new Exception("not found");

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