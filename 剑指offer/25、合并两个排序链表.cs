public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}
public class Solution
{
    public ListNode MergeSortedLists(ListNode head1,ListNode head2)
    {
        if(head1==null) return head2;
        else if(head2==null) return head1;

        ListNode head=new ListNode();
        ListNode temp1=new ListNode();//暂存head1.next
        ListNode temp2=new ListNode();//暂存head1.next.next
        ListNode temp3=new ListNode();//暂存head2.next

        if(head2.val<head1.val)
        {
            head=head1;
            head1=head2;
            head2=head;
        }

        head=head1;

        while(temp2!=null&&head2!=null)
        {
            temp1=head1.next;
            temp2=head1.next.next;
            temp3=head2.next;
            if(head2.val<=temp1.val)
            {
                head1.next=head2;
                head2.next=temp1;
                head2=temp3;
                head1=head1.next;
            }
            else if(head2.val<=temp2.val)
            {
                temp1.next=head2;
                head2.next=temp2;
                head2=temp3;
                head1=head1.next.next;
            }
            else
            {
                head1=temp1;
                temp1=head1.next;
            }
        }

        if(head2!=null)
        {
            temp1.next=head2;
        }

        retrurn head;
    }
}