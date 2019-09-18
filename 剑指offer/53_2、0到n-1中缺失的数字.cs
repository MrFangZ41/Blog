public class Solution
{
    //由于m不在数组中，所以m+1在下标为m的位置，m+2在下标为m+1的位置上，以此类推
    public int GetMissingNum(int[] nums)
    {
        if(nums==null||nums.Length<=0)
        {
            return -1;
        }

        int lo=0;
        int hi=nums.Length-1;

        while(lo<=hi)
        {
            int mid=(lo+hi)/2;
            if(nums[mid]!=mid)
            {
                if(mid==0||nums[mid-1]==mid-1)
                {
                    return mid;
                }
                hi=mid-1;
            }
            else
            {
                lo=mid+1;
            }
        }

        if(lo==nums.Length)
        {
            return nums.Length;
        }

        return -1;
    }
}