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
    //中序遍历即可
    public TreeNode KthNode(TreeNode root,int k)
    {
        if(root==null||k<=0)
        {
            return null;
        }
    }

    public TreeNode KthNodeCore(TreeNode root,int k)
    {
        TreeNode res=null;
        
        if(root.left!=null)
        {
            res=KthNodeCore(root.left,k);
        }

        if(res==null)
        {
            if(k==1)
            {
                return root;
            }
            else
            {
                k--;
            }
        }

        if(res==null&&root.right!=null)
        {
            res=KthNodeCore(root.right,k);
        }

        return res;
    }
}