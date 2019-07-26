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
    public TreeNode Rebuild(int[] preoder,int[] inoder)
    {

    }

    public TreeNode Reconstruct(int[] preoder,int startpre,int endpre,int[] inoder,int startin,int endin)
    {
        if(startpre>endpre||startin>endin)
        {
            return null;
        }

        TreeNode root=new TreeNode(startpre);

        for(int i=startin;i<=endin;i++)
        {
            if(inoder[i]==preoder[startpre])
            {
                root.left=Reconstruct(preoder,startpre+1,startpre+i-startin,inoder,startin,i-1);
                root.right=Reconstruct(preoder,i-startin+startpre+1,endpre,inoder,i+1,endin);
                break;

                //startpre+1是前序遍历左子树开始的位置
                //i-startin是中序遍历中左子树的长度
                //startpre+(i-startin)是前序遍历左子树结束的位置
            }

            return root;
        }
    }
}