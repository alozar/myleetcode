/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var carry = 0;
        var sum = 0;
        ListNode dummyListNode = new ListNode(0);
        ListNode current = dummyListNode;
        while (l1 != null || l2 != null || carry != 0)
        {
            sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }
            
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        return dummyListNode.next;
    }
}