/*在一个数组中除一个数字只出现一次之外，其他数字都出现了三次。请找出那个只出现一次的数字 */
public class Solution
{
    public int FindNumAppearOnce(int[] nums)
    {
        if(nums==null||nums.Length<2)
        {
            throw new IndexOutOfRangeException();
        }

        int[] bitsum=new int[32];
        for(int i=0;i<nums.Length;i++)
        {
            int bitmask=1;
            for(int j=31;j>=0;j--)
            {
                int bit=nums[i]&bitmask;
                if(bit!=0)
                {
                    bitsum[j]+=1;
                }

                bitmask=bitmask<<1;
            }
        }

        int res=0;
        foreach(int i in bitsum)
        {
            res=res<<1;
            res+=i%3;
        }

        return res;
    }
}