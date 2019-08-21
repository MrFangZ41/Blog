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
    public bool isSymmetrical(TreeNode root)
    {
        return isSymmetrical(root,root);
    }

    public bool isSymmetrical(TreeNode root1,TreeNode root2)
    {
        if(root1==null&&root2==null)
        {
            return true;
        }

        if(root1==null||root2==null)
        {
            return false;
        }

        if(root1.val==root2.val)
        {
            return isSymmetrical(root1.left,root2.right)&&isSymmetrical(root1.right,root2.left);
        }

        return false;
    }
}