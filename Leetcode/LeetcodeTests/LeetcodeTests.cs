using Microsoft.VisualStudio.TestTools.UnitTesting;
using S1TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    [TestClass()]
    public class LeetcodeTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            LeetCodeTwoSum ts = new LeetCodeTwoSum();
            int target = 9;
            int[] results;

            //int[] nums = { 1, 34, 3, 2, 7, 11, 15 };
            // target = 9;
            // results=ts.TwoSum(nums, target);

            //Assert.AreEqual(3, results[0]);
            //Assert.AreEqual(4, results[1]);

            //int[] nums2 ={ 2, 7, 11, 15 };
            //target = 9;
            //results = ts.TwoSum(nums2, target);
            //Assert.AreEqual(0, results[0]);
            //Assert.AreEqual(1, results[1]);

            int[] nums3 = {-3,4,3,90 };
            target = 0;
            results = ts.TwoSum(nums3, target);
            Assert.AreEqual(0, results[0]);
            Assert.AreEqual(2, results[1]);
        }
    }
}