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
    public int TreeDepth(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }

        int left=TreeDepth(root.left);
        int right=TreeDepth(root.right);

        return (left>right)?(left+1):(right+1);
    }
}