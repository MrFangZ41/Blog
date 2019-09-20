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
    public bool IsBalanced(TreeNode root)
    {
        int[] depth={0};
        return IsBalanced(root,depth);
    }

    public bool IsBalanced(TreeNode root,int[] depth)
    {
        if(root==null)
        {
            depth[0]=0;
            return true;
        }

        int[] left={0};
        int[] right={0};

        if(IsBalanced(root.left,left)&&IsBalanced(root.right,right))
        {
            int dif=left[0]-right[0];
            if(Math.Abs(dif)<=1)
            {
                depth[0]=1+(left>right?left:right);
                return true;
            }
        }
        
        return false;
    }
}