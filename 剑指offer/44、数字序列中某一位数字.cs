public class Solution
{
    public int DigitAtIndex(int n)
    {
        if(n<0) return -1;
        if(n<10) return n;

        int cur=10,len=2;
        int boundnum=10;
        while(cur+numlength(len)<n)
        {
            cur+=numlength(len);
            boundnum*=10;
            len++;
        }

        int addnum=(n-cur)/len;//计算是从10^(len-1)【如100】开始的第addnum个数字
        int curnum=boundnum+addnum;
        string s=curnum.ToString();
        int res=s[(n-cur)%len]-'0';

        return res;
    }

    public int numlength(int len)
    {
        int count=9;
        for(int i=1;i<len;i++)
        {
            count*=10;
        }
        return count*len;
    }
}