public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}
public class Solution
{
    //要考虑链表有无环
    public ListNode FindFirstCommonNode(ListNode head1,ListNode head2)
    {
        if(head1==null||head2==null)
        {
            return null;
        }

        ListNode loop1=GetLoopNode(head1);
        ListNode loop2=GetLoopNode(head2);

        if(loop1==null&&loop2==null)
        {
            return NoLoop(head1,head2);
        }

        if(loop1!=null&&loop2!=null)
        {
            return BothLoop(head1,head2,loop1,loop2);
        }

        return null;
    }

    public ListNode GetLoopNode(ListNode head)
    {
        if(head==null)
        {
            return null;
        }

        ListNode p1=head.next;
        ListNode p2=head.next.next;

        while(p1!=p2)
        {
            if(p2.next==null||p2.next.next==null)
            {
                return null;
            }

            p1=p1.next;
            p2=p2.next.next;
        }

        p2=head;

        while(p1!=p2)
        {
            p1=p1.next;
            p2=p2.next;
        }

        return p1;
    }

    public ListNode NoLoop(ListNode head1,ListNode head2)
    {
        if(head1==null||head2==null)
        {
            return null;
        }

        int n=LengthDif(head1,head2);

        ListNode cur1=n>0?head1:head2;//cur1指向较长的一个链表
        ListNode cur2=cur1==head1?head2:head1;

        n=Math.Abs(n);

        while(n!=0)
        {
            cur1=cur1.next;
            n--;
        }

        while(cur1!=cur2)
        {
            cur1=cur1.next;
            cur2=curr2.next;
        }

        return cur1;
    }

    public ListNode BothLoop(ListNode head1,ListNode head2,ListNode loop1,ListNode loop2)
    {
        ListNode cur1=null;
        ListNode cur2=null;

        if(loop1==loop2)
        {
            int n=LengthDif(head1,head2);

            cur1=n>0?head1:head2;
            cur2=cur1==head1?head2:head1;
            n=Math.Abs(n);

        while(n!=0)
        {
            cur1=cur1.next;
            n--;
        }

        while(cur1!=cur2)
        {
            cur1=cur1.next;
            cur2=curr2.next;
        }

        return cur1;
        }
        else
        {
            cur1=loop1.next;
            while(cur1!=loop1)
            {
                if(cur1==loop2)
                {
                    return loop1;
                }

                cur1=cur1.next;
            }

            return null;
        }
    }

    public int LengthDif(ListNode head1,ListNode head2)
    {
        ListNode cur1=head1;
        ListNode cur2=head2;

        int n=0;

        while(cur1.next!=null)
        {
            n++;
            cur1=cur1.next;
        }

        while(cur2.next!=null)
        {
            n--;
            cur2=cur2.next;
        }

        return n;
    }
}