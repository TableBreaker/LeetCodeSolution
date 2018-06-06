using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolution
{
    class Problem2 : Problem
    {
        public  class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public override void Execute()
        {
            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var node = AddTwoNumbers(l1, l2);
            while(node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var c1 = l1;
            var c2 = l2;
            var carry = 0;
            ListNode first = null;
            ListNode current = null;
            while (c1 != null || c2 != null)
            {
                var v1 = c1 == null ? 0 : c1.val;
                var v2 = c2 == null ? 0 : c2.val;
                var sum = v1 + v2 + carry;
                var v = sum % 10;
                var node = new ListNode(v);
                if (current == null)
                {
                    current = node;
                }
                else
                {
                    current.next = node;
                    current = current.next;
                }

                if (first == null)
                {
                    first = node;
                }
                carry = sum / 10;

                c1 = c1?.next;
                c2 = c2?.next;
            }
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }
            return first;
        }
    }
}
