public class Solution
{
    //关键在于arr和aux交替成为辅助数组！！！！
    public int InversePairs(int[] arr)
    {
        if(arr==null||arr.Length<=0)
        {
            throw new IndexOutOfRangeException();
        }

        int[] aux=new int[arr.Length];

        arr.CopyTo(aux,0);

        return InversePairsCore(arr,aux,0,arr.Length-1);
    }

    public int InversePairsCore(int[] arr,int[] aux,int lo,int hi)
    {
        if(lo==hi)
        {
            aux[lo]=arr[lo];
            return 0;
        }

        int len=(hi-lo)/2;

        int left=InversePairsCore(aux,arr,lo,lo+len);
        int right=InversePairsCore(aux,arr,lo+len+1,hi);

        int p1=lo+len;
        int p2=hi;
        int p3=hi;
        int count=0;

        while(p1>=lo&&p2>=lo+len+1)
        {
            if(arr[p1]>arr[p2])
            {
                count+=p2-lo-len;
                aux[p3--]=arr[p1--];
            }
            else
            {
                aux[p3--]=arr[p2--];
            }
        }

        while(p1>=lo)
        {
            aux[p3--]=arr[p1--];
        }

        while(p2>=lo+len+1)
        {
            aux[p3--]=arr[p2--];
        }

        return count+left+right;
    }
}