using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S198HouseRobber
{
    public class HouseRobber
    {
        public static int[] result;

        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int[] result = new int[nums.Length];

            result[0] = nums[0];
            result[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                result[i] = Math.Max(nums[i] + result[i - 2], result[i - 1]);
            }
            return result[nums.Length - 1];
        }

        public int Rob2(int[] nums)
        {
            result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = -1;
            }
            return solve(nums.Length-1, nums);
        }

        public int solve(int idx, int[] nums)
        {
            if (idx < 0)
            {
                return 0;
            }
            if (result[idx] < 0)
            {
                result[idx] = Math.Max(nums[idx] + solve(idx - 2, nums), solve(idx - 1, nums));
            }
            
            return result[idx];
        }

    }
}