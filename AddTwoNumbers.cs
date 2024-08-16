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
        /*ListNode head = new ListNode();
        ListNode node = head;
        int carry = 0;
        int d1 = 0;
        int d2 = 0;
        int sum = 0;
        int digit = 0;

        while (l1 != null || l2 != null || carry != 0) {
            d1 = (l1 != null) ? l1.val : 0;
            d2 = (l2 != null) ? l2.val : 0;

            sum = d1 + d2 + carry;
            carry = sum / 10;
            digit = sum % 10;

            ListNode newNode = new ListNode(digit);
            node.next = newNode;
            node = node.next;
            
            if (l1 != null) {
                l1 = l1.next;
            }
            else {
                l1 = null;
            }
            if (l2 != null) {
                l2 = l2.next;
            }
            else {
                l2 = null;
            }
        }

        return head.next; */

        int num1 = 0;
        int num2 = 0;
        double n = 0;

        while (l1 != null) {
            num1 += l1.val * (int)Math.Pow(10,n);
            l1 = l1.next;
            n++;
        }

        Console.WriteLine($"done l1, result is {num1}");

        n = 0;
        while (l2 != null) {
            num2 += l2.val * (int)Math.Pow(10,n);
            l2 = l2.next;
            n++;
        }

        Console.WriteLine($"done l2, result is {num2}");

        int sol = num1 + num2;
        Console.WriteLine($"answer: {sol}");
        ListNode head = new ListNode();
        ListNode node = new ListNode();
        head.next = node;

        Console.WriteLine($"done head node");

        while (sol > 0) {
            node.val = sol % 10;
            Console.WriteLine($"sol: {sol / 10}, node.val: {sol % 10}");
            sol = sol / 10; 
            if (sol != 0) {
                ListNode newNode = new ListNode();
                node.next = newNode;
                node = node.next;
            }
        }

        return head.next;
    }
}
