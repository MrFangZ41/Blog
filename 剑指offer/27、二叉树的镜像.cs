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
    public void MirrorTree(TreeNode root)
    {
        if(root==null) return;
        if(root.left==null&&root.right==null) return;

        TreeNode temp=root.left;
        root.left=root.right;
        root.right=temp;
        
        MirrorTree(root.left);
        MirrorTree(root.right);
    }
}