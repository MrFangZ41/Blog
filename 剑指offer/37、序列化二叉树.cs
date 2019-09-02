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
    //序列化
    public void Serialize(TreeNode root,List<int> stream)
    {
        if(root==null)
        {
            stream.Add(null);
            return;
        }

        stream.Add(root.val);
        Serialize(root.left,stream);
        Serialize(root.right,stream);
    }

    //反序列化
    public TreeNode Deserialize(Treenode root,List<int> stream)
    {
        if(stream[0]==null)
        {
            stream.RemoveAt(0);
            return null;
        }

        root=new TreeNode(stream.RemoveAt(0));
        root.left=Deserialize(root.left,stream);
        root.right=Deserialize(root.right,stream);

        return root;       
    }
}