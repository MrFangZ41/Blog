public class Solution
{
    public int[] FindNumsAppearOnce(int[] nums)
    {
        if(nums==null||nums.Length<2)
        {
            throw new IndexOutOfRangeException();
        }

        int xor=0;
        int[] res=new int[2];
        foreach(int i in nums)
        {
            xor^=i;
        }

        int indexof1=FindFirstBitIs1(xor);
        
        foreach(int i in nums)
        {
            if(isBit1(i,indexof1))
            {
                res[0]^=i;
            }
            else
            {
                res[1]^=i;
            }
        }

        return res;

    }

    public int FindFirstBitIs1(int xor)
    {
        int index=0;
        while(index<32&&(xor&1)==0)
        {
            index++;
            xor=xor>>1;
        }

        return index;
    }

    public bool isBit1(int i,int index)
    {
        i=i>>index;
        return (i&1)==1;
    }
}