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
            TwoSum ts = new TwoSum();

            int[] nums = { 1, 34, 3, 2, 7, 11, 15 };
            int target = 9;
            int[] results=ts.TwoSum(nums, target);

            Assert.AreEqual(3, results[0]);
            Assert.AreEqual(4, results[1]);
        }
    }
}