// Link: https://leetcode.com/problems/add-two-numbers/

namespace SumitGouthaman.LeetcodeSolutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Sol002AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

            int val = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
            var result = new ListNode(val % 10);
            if (l1?.next != null || l2?.next != null || val >= 10)
                result.next = AddTwoNumbers(l1?.next, l2?.next, (val >= 10) ? 1 : 0);

            return result;
        }
    }
}
