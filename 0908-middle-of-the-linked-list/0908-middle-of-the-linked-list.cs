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
    public ListNode MiddleNode(ListNode head) {
        var nodeCount = 1;
        ListNode temp = head;
        while (temp.next is not null)
        {
            temp = temp.next;
            nodeCount++;
        }

        for (var i = 0; i < nodeCount / 2; i++)
        {
            head = head.next;
        }

        return head;
    }
}