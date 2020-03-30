using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_nextGreaterNodeInLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(2);

            ListNode node1 = new ListNode(7);
            ListNode node2 = new ListNode(4);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(5);

            Solution s = new Solution();

            s.NextLargerNodes(head);
        }
    }

    /**
 * Definition for singly-linked list.
 */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class Solution
    {
        public int[] NextLargerNodes(ListNode head)
        {
            ListNode p = head;
            ListNode q = head;

            List<int> result = new List<int>();

            while (q != null)
            {
                int currentValue = p.val;
                int nextValue = 0;

                q = q.next;

                while (q != null)
                {
                    if (q.val > currentValue)
                    {
                        nextValue = q.val;
                        break;
                    }

                    q = q.next;
                }

                result.Add(nextValue);
                p = p.next;
                q = p;
            }

            return result.ToArray();
        }
    }
}

