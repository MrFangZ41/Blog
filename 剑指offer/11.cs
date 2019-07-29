public class solution
{
    public int Min(int[] nums)
    {
        if(nums[0]<nums[nums.Length-1]) return nums[0];
        int left=0;
        int right=nums.Length-1;
        while(left<right)
        {
            int mid=(left+right)/2;
            if(nums[mid]>nums[right]) left=mid+1;
            else right=mid;
        }
        
        return nums[left];
    }
}