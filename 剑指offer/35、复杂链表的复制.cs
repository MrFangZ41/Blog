public class RandomListNode
{
    public int label;
    public RandomListNode next,random;
    public RandomListNode(int x)
    {
        this.label=x;
    }
}

public class Solution
{
    public RandomListNode CopyRandomList(RandomListNode head)
    {
        if(head==null) return null;
        RandomListNode index=head;
        while(index!=null)
        {
            TreeNode node=new TreeNode(index.label);
            node.next=index.next;
            index.next=node;
            index=node.next;
        }

        index=head;

        while(index!=null)
        {
            index.next.random=(index.random==null)?null:index.random.next;
            index=index.next.next;
        }

        TreeNode newhead=head.next;
        TreeNode newindex=head.next;
        TreeNode oldindex=head;

        while(oldindex!=null)
        {
            oldindex.next=oldindex.next.next;
            newindex.next=(oldindex.next!=null)?newindex.next.next:null;
            oldindex=oldindex.next;
            newindex=newindex.next;
        }

        return newhead;
    }
}