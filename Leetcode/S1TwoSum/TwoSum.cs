using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1TwoSum
{
    public class TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IList<int> newNums = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= target)
                {
                    newNums.Add(nums[i]);
                }
            }
        }

        private int[] TwoSumHelper(List<int> newNums)
        {

        }
    }
}
