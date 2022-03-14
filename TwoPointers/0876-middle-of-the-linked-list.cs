
// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/
// Difficulty: Easy

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
        ListNode slow = head;
        ListNode fast = head; 
        while(fast != null  && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
            
        }
        return slow;
        
    }
}

        