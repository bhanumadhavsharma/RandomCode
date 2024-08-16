/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null) {
            return list1;
        }
        else if (list1 == null && list2 != null) {
            return list2;
        }
        else if (list1 != null && list2 == null) {
            return list1;
        }

        if (list1.val <= list2.val) {
            list1.next = mergeTwoLists(list1.next, list2);
            return list1;
        }
        else {
            list2.next = mergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}

/* brute force
if (list1 == null && list2 == null) {
            return list1;
        }
        else if (list1 == null && list2 != null) {
            return list2;
        }
        else if (list1 != null && list2 == null) {
            return list1;
        }

        ListNode head = list1;
        boolean setOnce = false;

        ListNode curList1 = list1;
        ListNode curList2 = list2;
        // debug
        int i = 0;
        while (curList1 != null && curList2 != null) {
            i++;
            System.out.println("run:" + i);
            //1
            if (list1.val > list2.val) {
                //a
                if (list1 == curList1) {
                    if (!setOnce) {
                        head = list2;
                        setOnce = true;
                    }                    
                    //i
                    if (list2.next != null && list1.val > list2.next.val) {
                        list2 = list2.next;
                        curList2 = list2;
                    }
                    //ii
                    else if (list2.next != null) {
                        curList2 = list2.next;
                        list2.next = list1;
                        list2 = curList2;
                    }
                    //iii
                    else {
                        list2.next = list1;
                        break;
                    }                    
                }
                //b
                else {
                    list1 = curList1;
                    //i
                    if (list2.next != null && list1.next.val > list2.next.val) {
                        curList1 = list1.next;
                        curList2 = list2.next;
                        list1.next = list2;
                        list2 = curList2;
                        list1 = curList1;
                    } 
                    else if (list2.next != null) {
                        curList2 = list2.next;
                        list2.next = list1.next;
                        curList1 = list1.next;  
                        list1.next = list2;
                        list2 = curList2;                                              
                        list1 = curList1;
                    }
                    //ii                 
                    else {
                        list2.next = list1.next;
                        list1.next = list2;
                        break;
                    }
                }
            }
            //2
            else {
                curList1 = list1;
                //a
                if (list1.next != null) {
                    list1 = list1.next;
                }
                //b
                else {
                    list1.next = list2;
                    break;
                }
                setOnce = true;           
            }
        }

        return head;
*/
