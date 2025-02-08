using System.ComponentModel.Design;

namespace AddTwoNumbers
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

    public class AddTwoNum
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            return AddRecursive(l1, l2, 0);
        }

        private ListNode AddRecursive(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            return new ListNode(sum % 10, AddRecursive(l1?.next, l2?.next, sum / 10));
        }
    }
}

