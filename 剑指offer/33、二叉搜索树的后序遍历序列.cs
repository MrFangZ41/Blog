public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x)
    {
        val=x;
    }
}

public class Solution
{
    public bool VerifySequenceOfBST(int[] postorder)
    {
        if(postorder==null||postorder.Length<=0)
        {
            return false;
        }

        return isPostorder(postorder,0,postorder.Length-1);
    }

    public bool isPostorder(int[] sequence,int start,int end)
    {
        if(start>=end) return true;
        int root=sequence[end];
        int index=0;
        while(sequence[index]<root&&index<end-1)
        {
            index++;
        }

        int mid=index;//找出左子树和右子树的分界

        while(sequence[index]>root&&index<end-1)
        {
            index++;
        }

        if(index!=end-1)
        {
            return false;
        }

        return isPostorder(sequence,start,mid-1)&&isPostorder(sequence,mid,end-1);
    }
}