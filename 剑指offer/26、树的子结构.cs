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
    public bool HasSubtree(TreeNode root1,TreeNode root2)
    {
        if(root1==root2)
        {
            return true;
        }
        if(root1==null)
        {
            return false;
        }
        if(root2==null)
        {
            return false;
        }

        bool res=false;

        if(root1.val==root2.val)
        {
            res=Match(root1,root2);
        }

        if(!res)
        {
            res=HasSubtree(root1.left.root2);
        }

        if(!res)
        {
            res=HasSubtree(root1.right,root2);
        }

        return res;
    }

    public bool Match(TreeNode node1,TreeNode node2)
    {
        if(node1==node2) return true;
        if(node1==null) return false;
        if(node2==null) return false;

        return Match(node1.left,node2.left)&&Match(node1.right,node2.right);
    }
}