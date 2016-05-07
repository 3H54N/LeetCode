using Microsoft.VisualStudio.TestTools.UnitTesting;
using S1TwoSum;
using S2AddTwoNumbers;
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
            string s = "0.000000000000000000000000";
            decimal ss = decimal.Parse(s);

            decimal zero = 0m;

            decimal result = zero * ss;

            decimal one = 2.30000000000000M;
            //result = one / ss;


            decimal zeros = zero + 0.00000000000000000000000M;

            decimal testNums = 1233.2m;

            decimal zero11 = testNums + ss;
            Console.WriteLine(zero11);


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

            int[] nums3 = { -3, 4, 3, 90 };
            target = 0;
            results = ts.TwoSum(nums3, target);
            Assert.AreEqual(0, results[0]);
            Assert.AreEqual(2, results[1]);
        }


        [TestMethod]
        public void AddTwoNumbersTest()
        {
            ListNode l1 = new ListNode(9);
            ListNode l11 = new ListNode(9);
            l1.next = l11;
            //ListNode l111 = new ListNode(3);
            //l11.next = l111;

            ListNode l2 = new ListNode(9);
            ListNode l21 = new ListNode(9);
            l2.next = l21;
            //ListNode l211 = new ListNode(4);
            //l21.next = l211;
            //ListNode l2 = new ListNode("564");

            S2AddTwoNumbers.S2AddTwoNumbers s2 = new S2AddTwoNumbers.S2AddTwoNumbers();
           ListNode result = s2.AddTwoNumbers(l1, l2);
           Assert.AreEqual("891", result.ToString());

            Assert.AreEqual("243", l1.ToString());
            //Assert.AreEqual("564", l1.ToString());
            //Assert.AreEqual("708", result.ToString());
        }
    }
}
