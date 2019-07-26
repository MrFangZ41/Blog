public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x)
    {
        val=x;
    }
}//create 

public class Solution
{
    public TreeNode Rebuild(int[] preorder,int[] inorder)
    {
        TreeNode root=Reconstruct(preorder,0,preorder.Length-1,inorder,0,inorder.Length-1);

        return root;
    }

    public TreeNode Reconstruct(int[] preorder,int startpre,int endpre,int[] inorder,int startin,int endin)
    {
        if(startpre>endpre||startin>endin)
        {
            return null;
        }

        TreeNode root=new TreeNode(startpre);

        for(int i=startin;i<=endin;i++)
        {
            if(inorder[i]==preorder[startpre])
            {
                root.left=Reconstruct(preorder,startpre+1,startpre+i-startin,inorder,startin,i-1);
                root.right=Reconstruct(preorder,i-startin+startpre+1,endpre,inorder,i+1,endin);
                break;

                //startpre+1是前序遍历左子树开始的位置
                //i-startin是中序遍历中左子树的长度
                //startpre+(i-startin)是前序遍历左子树结束的位置
            }

            return root;
        }
    }
}