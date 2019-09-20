public class Solution
{
    public IList<IList<int>> FindContinuousSequence(int s)
    {
        IList<IList<int>> res=new List<List<int>>();
        if(s<3)
        {
            return res;
        }

        int p1=1;
        int p2=2;
        int mid=(1+s)/2;//如果p1>mid，因为p2>p1，则p1+p2>s

        int sum=p1+p2;
        while(p1<mid)
        {
            if(sum==s)
            {
                AddListToResult(p1,p2,result);
            }

            while(sum>s&&p1<mid)
            {
                sum-=p1;
                p1++;
                if(sum==s)
                {
                    AddListToResult(p1,p2,result);
                }
            }

            p2++;
            sum+=p2;
        }

        return res;
    }

    public void AddListToResult(int p1,int p2,IList<IList<int>> res)
    {
        IList<int> list=new List<int>();
        for(int i=p1;i<=p2;i++)
        {
            list.Add(i);
        }

        res.Add(list);
    }
}