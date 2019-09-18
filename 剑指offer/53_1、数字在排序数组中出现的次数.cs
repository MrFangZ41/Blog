public class Solution
{
    public int GetNumberOfK(int[] nums,int k)
    {
        if(nums==null||nums.Length<=0)
        {
            return -1;
        }

        int first=GetFirstK(nums,k,0,nums.Length-1);
        int last=GetLastK(nums,k,0,nums.Length);

        if(first>-1&&last>-1)
        {
            return last-first+1;
        }

        return 0;
    }

    public int GetFirstK(int[] nums,int k,int lo,int hi)
    {
        if(lo>hi)
        {
            return -1;
        }

        int mid=(lo+hi)/2;

        if(nums[mid]==k)
        {
            if(mid>0&&nums[mid-1]!=k||mid==0)
            {
                return mid;
            }
            else
            {
                end=mid-1;
            }
        }
        else if(nums[mid]>k)
        {
            end=mid-1;
        }
        else
        {
            start=mid+1;
        }

        return GetFirstK(nums,k,start,end);
    }

    public int GetLastK(int[] num,int k,int start,int end)
    {
        if(lo>hi)
        {
            return -1;
        }

        int mid=(lo+hi)/2;

        if(nums[mid]==k)
        {
            if(mid<nums.Length-1&&nums[mid+1]!=k||mid==nums.Length-1)
            {
                return mid;
            }
            else
            {
                start=mid+1;
            }
        }
        else if(nums[mid]<k)
        {
            start=mid+1;
        }
        else
        {
            end=mid-1;
        }

        return GetLastK(nums,k,start,end);
    }
}