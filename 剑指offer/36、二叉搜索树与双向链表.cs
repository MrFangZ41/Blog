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
    public TreeNode Convert(TreeNode root)
    {
        if(root==null)
        {
            return null;
        }

        TreeNode[] temp=new TreeNode[1];
        temp[0]=null;
        Inorder(root,temp);
        head=temp[0];
        while(head!=null&&head.left!=null)
        {
            head=head.left;
        }

        return head;
    }

    public void Inorder(TreeNode node,TreeNode[] temp)
    {
        if(node==null) return;

        if(node.left!=null)
        {
            Inorder(node.left,temp);
        }

        node.left=temp[0];//设置node的前项结点

        if(temp[0]!=null)
        {
            temp[0].right=node;
        }

        temp[0]=node;

        if(node.right!=null)
        {
            Inorder(node.right,temp);
        }


    }
}