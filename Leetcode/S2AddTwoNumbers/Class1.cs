using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2AddTwoNumbers
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        private int i = 0;
        private String nums = null;
        public override string ToString()
        {
            return val + toString(this.next);
        }
        private String toString(ListNode ln)
        {
            if (ln == null)
            {
                return "";
            }

            return ln.val + toString(ln.next);
        }

        public ListNode(String numbers)
        {
            ListNode next = null;
            ListNode parent = null;
            foreach (var number in numbers)
            {                
                if (next == null)
                {
                    this.val = int.Parse(number.ToString());
                    next = this;
                    parent = this;
                }
                else
                {
                    next = new ListNode(int.Parse(number.ToString()));
                    parent.next = next;
                    parent = next;
                }
            }
        }


    }

    public class S2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return getListNode(getSum(l1, l2, 1).ToString());
        }

        private decimal getSum(ListNode l1, ListNode l2, decimal digits)
        {
            if (l1 == null && l2 == null)
            {
                return 0;
            }
            if (l1 == null)
            {
                l1 = new ListNode(0);
            }
            if (l2 == null)
            {
                l2= new ListNode(0);
            }
            decimal sum = (l1.val + l2.val) * digits;

            return sum + getSum(l1.next, l2.next, digits * 10);
        }

        public ListNode getListNode(String numbers)
        {
            ListNode next = null;
            ListNode parent = null;
            foreach (var number in numbers)
            {
                parent = new ListNode(int.Parse(number.ToString()));
                if (next == null)
                {
                    next = parent;
                }
                else
                {
                    parent.next = next;
                    next = parent;
                }
            }
            return parent;
        }



    }
}
