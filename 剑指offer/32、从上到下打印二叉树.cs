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
    public void PrintTree(TreeNode root)
    {
        if(root==null)
        {
            return;
        }

        Queue q=new Queue();
        q.Enqueue(root);
        TreeNode cur=null;

        while(q.Count!=0)
        {
            cur=q.Dequeue();
            System.Console.WriteLine(cur.val);

            if(cur.left!=null)
            {
                q.Enqueue(cur.left);
            }

            if(cur.right!=null)
            {
                q.Enqueue(cur.right);
            }
        }
    }

}