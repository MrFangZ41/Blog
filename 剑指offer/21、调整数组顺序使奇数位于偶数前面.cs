public class Solution
{
    public void Reorder(int[] nums)
    {
        int l=nums.Length;
        if(l==0) return;
        int start=0;
        int end=l-1;
        while(start<end)
        {
            while(start<end&&(nums[start]%2!=0))
            {
                start++;
            }

            while(start<end&&(nums[end]%2==0))
            {
                end--;
            }

            if(start<end)
            {
                int temp=nums[start];
                nums[start]=nums[end];
                nums[end]=temp;
            }
        }
    }
}