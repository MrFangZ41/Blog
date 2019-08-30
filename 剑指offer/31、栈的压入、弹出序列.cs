public class Solution
{
    public bool isPopOrder(int[] push,int[] pop)
    {
        if(push==null||pop==null||push.Length==0||pop.Length==0||push.Length!=pop.Length)
        {
            return false;
        }

        int pushIndex=0;
        int popIndex=0;
        Stack<int> s=new Stack<int>();

        while(popIndex<pop.Length)
        {
            while(pushIndex<push.Length&&(s.Count==0||pop[popIndex]!=s.Peek()))
            {
                s.Push(push[pushIndex++]);
            }

            if(pop[popIndex]==s.Peek())
            {
                s.Pop();
                popIndex++;
            }
            else return false;
        }

        return true;
    }
}