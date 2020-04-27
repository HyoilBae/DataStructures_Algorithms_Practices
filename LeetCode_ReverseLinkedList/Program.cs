using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            while (head != null)
            {
                stack.Push(head);
                head = head.next;
            }

            ListNode dummy = new ListNode(-1);
            head = dummy;
            while (stack.Count != 0)
            {
                ListNode current = stack.Pop();
                head.next = new ListNode(current.val);
                head = head.next;
            }

            return dummy.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
