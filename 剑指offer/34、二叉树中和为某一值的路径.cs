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
    public void FindPath(TreeNode root,int sum)
    {
        if(root==null)
        {
            return;
        }

        List<int> res=new List<int>();
        int cur=0;
        Find(root,sum,cur,res);
    }

    public void Find(TreeNode root,int sum,int cur,List<int> res)
    {
        cur+=root.val;
        res.Add(root.val);
        if(root.left==null&&root.right==null&&cur==sum)
        {
            foreach(int i in res)
            {
                System.Console.WriteLine(i);
            }
        }

        if(root.left!=null)
        {
            Find(root.left,sum,cur,res);
        }

        if(root.right!=null)
        {
            Find(root.right,sum,cur,res);
        }

        res.RemoveAt(res.Count-1);
    }
}