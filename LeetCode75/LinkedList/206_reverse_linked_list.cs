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
    public ListNode ReverseList(ListNode head) {
        ListNode returnVal = null;
        ListNode prevNode = null;

        while (head != null){
            if (returnVal != null){
                prevNode = new ListNode(returnVal.val, returnVal?.next);
            }
            returnVal = new ListNode(head.val, prevNode);

            head = head.next;
        }

        return returnVal;
    }
}