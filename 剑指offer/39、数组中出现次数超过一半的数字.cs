public class Solution
{
    public int MoreThanHalfNum(int[] nums)
    {
        if(nums==null||nums.Length<=0)
        {
            return 0;
        }

        int res=nums[0];
        int times=1;
        for(int i=1;i<nums.Length;i++)
        {
            if(times==0)
            {
                res=nums[i];
                times=1;
            }
            else if(nums[i]==res)
            {
                times++;
            }
            else
            {
                times--;
            }
        }

        if(!CheckMoreThanHalf(nums,res)) return 0;

        return res;
    }

    public bool CheckMoreThanHalf(int[] nums,int num)
    {
        int times=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==num)
            {
                times++;
            }
        }

        if(2*times<=nums.Length) return false;

        return true;
    }
}