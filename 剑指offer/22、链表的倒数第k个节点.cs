public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}

public class Solution
{
    public Listnode FindKthToTail(ListNode head,int k)
    {
        ListNode node1=head;
        for(int i=0;i<k-1;i++)
        {
            node1=node1.next;
        }
        ListNode node2=head;
        while(node1.next!=null)
        {
            node1=node1.next;
            node2=node2.next;
        }

        return node2;
    }
}