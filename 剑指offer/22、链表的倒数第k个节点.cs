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
        if(head==null||k<=0) return null;
        ListNode node1=head;
        for(int i=0;i<k-1;i++)
        {
            if(node1.next!=null) node1=node1.next;
            else return null;//k大于链表节点数
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