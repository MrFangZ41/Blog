public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int sub=nums[0];
        int res=nums[0];

        for(int i=1;i<nums.Length;i++)
        {
            sub=Math.Max(nums[i],nums[i]+sub);
            res=Math.Max(res,sub);
        }

        return res;
    }
}