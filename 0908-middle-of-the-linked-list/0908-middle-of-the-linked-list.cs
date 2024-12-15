/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 *     public override string ToString()
 *     {
 *         var result = new StringBuilder($"[{val}");
 *         var temp = next;
 *         while (temp is not null)
 *         {
 *             result.Append($",{temp.val}");
 *             temp = temp.next;
 *         }
 *         result.Append("]");
 *         return result.ToString();
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        // time compexity O(n)
        // space compexity O(1)
        ListNode middle = head;
        ListNode end = head;
        while (end is not null && end.next is not null)
        {
            middle = middle.next;
            end = end.next.next;
        }

        return middle;
    }
}