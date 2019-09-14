public class Solution
{
    public int NumOfOne(int n)
    {
        if(n<=0)
        {
            return 0;
        }

        string s=n.ToString();
        char[] chars=s.ToCharArray();
        int[] nums=new int[chars.Length]; 
        for(int i=0;i<chars.Length;i++)
        {
            nums[i]=chars[i]-'0';
        }

        return Numof1(nums,0); 
    }

    public int Numof1(int[] nums,int index)
    {
        if(nums==null||nums.Length<=0||index>=num.Length)
        {
            return 0;
        }

        int first=nums[index];//最高位的数字
        int len=nums.Length-index;//处理数字的位数
        if(len==1&&first==0) return 0;
        if(len==1&&first>0) return 1;

        int numfirstdigit=0;
        if(first>1)
        {
            numfirstdigit=PowerBase10(len-1);
        }
        else if(first==1)
        {
            numfirstdigit=atoi(nums,index+1)+1;
        }

        int otherdigit=first*(len-1)*PowerBase10(len-2);

        int recursivenum=Numof1(nums,index=1);

        return recursivenum+numfirstdigit+otherdigit;
    }

    public int PowerBase10(int n)
    {
        int result=1;
        for(int i=0;i<n;i++)
        {
            result*=10;
        }

        return result;
    }

    public int atoi(int[] nums,int index)
    {
        int result=0;
        for(int i=index;i<nums.Length;i++)
        {
            result=result*10+nums[i];
        }

        return result;
    }
}