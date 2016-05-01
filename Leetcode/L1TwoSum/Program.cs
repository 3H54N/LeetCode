using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,34,3,2, 7, 11, 15 };
            int target = 9;

           int[] result = TwoSum(nums, target);

        }

        private static int[] TwoSum(int[] nums, int target)
        {
            IList<int> newNums = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]<=target)
                {
                    newNums.Add(nums[i]);
                }
            }
        }
    }
}
