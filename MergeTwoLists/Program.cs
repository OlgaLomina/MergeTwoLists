using System;
/*Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

Example:

Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
 * */
namespace MergeTwoLists
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class Program
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode head = new ListNode(0);
            ListNode l3 = head;
            ListNode cur1 = l1, cur2 = l2;

            while (cur1 != null || cur2 != null)
            {
                int val;
                if (cur1 != null && cur2 != null)
                {
                    int val1 = cur1.val;
                    int val2 = cur2.val;
                    if (val1 <= val2)
                    {
                        val = val1;
                        cur1 = cur1.next;
                    }
                    else
                    {
                        val = val2;
                        cur2 = cur2.next;
                    }
                }
                else if (cur1 == null)
                {
                    int val2 = cur2.val;
                    val = val2;
                    cur2 = cur2.next;
                }
                else
                {
                    int val1 = cur1.val;
                    val = val1;
                    cur1 = cur1.next;
                }
                l3.next = new ListNode(val);
                l3 = l3.next;
            }
            return head.next;
        }


        public static void Main()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            ListNode l3 = MergeTwoLists(l1, l2);
            while (l3.next != null)
            {
                Console.Write(l3.val + "->");
                l3 = l3.next;
            }
            Console.WriteLine(l3.val);
        }
    }
}
