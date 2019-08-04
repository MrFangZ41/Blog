public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}

public class solution
{
    public ListNode DeleteNode(ListNode head,ListNode ToBeDel)
    {
        if(head==null||ToBeDel==null) return;
        if(ToBeDel.next!=null)
        {
            ListNode temp=ToBeDel.next;
            ToBeDel.val=temp.val;
            ToBeDel.next=temp.next;
        }
        else if(ToBeDel==head)
        {
            head=null;
        }
        else
        {
            ListNode temp=head;
            while(temp.next!=ToBeDel)
            {
                temp=temp.next;
            }
            ToBeDel=null;
            temp.next=null;
        }

        return head;
    }
}
