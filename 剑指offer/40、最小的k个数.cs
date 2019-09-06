public class Solution
{
    public void GetLeastNum(int[] nums,int k)
    {
        if(nums==null||nums.Length<=0||nums.Length<k)
        {
            return;
        }

        int[] res=new int[k];

        for(int i=0;i<k;i++)
        {
            res[i]=nums[i];
        }

        int N=k-1;
        for(int i=k/2;i>=0;i--)
        {
            HeapSort(res,i,N);
        }

        for(int i=k;i<nums.Length;i++)
        {
            if(nums[i]<res[0])
            {
                res[0]=nums[i];
                HeapSort(res,0,N);
            }
        }

        foreach(int i in res)
        {
            System.Console.WriteLine(i);
        }
    }
    //调整堆，使得res[0]为最大值
    public void HeapSort(int[] res,int i,int N)
        {
            while(2*i<N)
            {
                int j=2*i+1;
                if(j<N&&res[i]<res[j+1])
                {
                    j++;
                }

                if(res[i]>res[j])
                {
                    break;
                }
                else
                {
                    Swap(ref res[i],ref res[j]);
                    i=j;
                }
            }
        }
    
    public void Swap(ref int a,ref int b)
    {
        int temp=a;
        a=b;
        b=temp;
    }
}