using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class DeleteNodesFromLinkedListPresentinArray
    {
        public static ListNode ModifiedList(int[] nums, ListNode head)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;

            while (current.next != null)
            {
                if (numSet.Contains(current.next.val))
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return dummy.next;
        }
    }
}
