/**
 * Definition for singly-linked list.
**/

class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

class Solution
{
    public static void Main()
    {
        var Result = AddTwoNumbers(new ListNode(0), new ListNode(1));
        Console.WriteLine(Result);
    }

    private static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if(l1 == null && l2 == null)
        {
            return null;
        }
        else if (l1 == null && l2 != null)
        {
            return l2;
        }
        else if (l1 != null && l2 == null)
        {
            return l1;
        }

        int summary = l1.val + l2.val;
        ListNode next = AddTwoNumbers(l1.next, l2.next);

        if (summary >= 10)
        {
            summary %= 10;
            next = AddTwoNumbers(next, new ListNode(1));
        } 

        return new ListNode(summary, next);
    }
}