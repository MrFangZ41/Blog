public class Solution
{
    public int GetNumSameAsIndex(int[] nums)
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
            if(nums[mid]==mid)
            {
                return mid;
            }

            if(nums[mid]>mid)
            {
                hi=mid-1;
            }
            else
            {
                lo=mid+1;
            }
        }

        return -1;
    }
}