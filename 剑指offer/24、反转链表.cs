
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if(head==null) return null;
        ListNode newhead=new ListNode();
        newhead.next=null;
        ListNode temp;
        while(head!=null)
        {
            temp=head.next;
            head.next=newhead.next;
            newhead.next=head;
            head=temp;
        }

        return newhead.next;
    }
}