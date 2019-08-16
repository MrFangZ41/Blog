
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x){val=x;}
}
public class Solution
{
    public ListNode MeeetingNode(ListNode head)
    {
        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null&&fast.next!=null)
        {
            fast=fast.next.next;
            slow=slow.next;
            //快节点一次走2步，慢节点一次走1步，如果有环，两节点必相遇
            if(slow==fast)
            {
                fast=head;//让快节点回到头节点，一次走1步
                while(slow!=fast)
                {
                    //慢节点也一次走1步，相遇时的节点为入环节点
                    fast=fast.next;
                    slow=slow.next;
                }
                return slow;
            }
        }
        return null;
    }
}