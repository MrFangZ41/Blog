public class Solution
{
    public int[] FindNumWithSum(int nums,int s)
    {
        if(nums==null||nums.Length<2)
        {
            throw new IndexOutOfRangeException();
        }

        int[] res=new int[2];
        int p1=0;
        int p2=nums.Length-1;
        long sum=0;
        
        while(p1<p2)
        {
            sum=nums[p1]+nums[p2];
            if(sum==s)
            {
                res[0]=nums[p1];
                res[1]=nums[p2];
            }
            else if(sum>s)
            {
                p2--;
            }
            else
            {
                p1++;
            }
        }

        return res;
    }
}