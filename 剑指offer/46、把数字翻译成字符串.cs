public class Solution
{
    //自下而上，动态规划
    //f(i)=f(i+1)+g(i,i+1)*f(i+2)
    //g(i,i+1)判断num[i]与num[i+1]组合的数字是否可以翻译成字母
    //其中f(i+1)表示num[i]单独翻译成字母
    public int GetTransCount(int num)
    {
        if(num<0)
        {
            return 0;
        }
    }

    public int GetCount(string s)
    {
        int[] dp=new dp[s.Length];
        dp[s.Length]=0;
        dp[s.Length-1]=dp[s.Length-2]=1;
        for(int i=s.Length-3;i>=0;i--)
        {
            if(isChar)
            {
                dp[i]=dp[i+1]+dp[i+2];
            }
            else
            {
                dp[i]=dp[i+1];
            }
        }

        return dp[0];
    }

    public bool isChar(char a,char b)
    {
        string s=a+b+"";
        if(s.CompareTo("10")>=0&&s.CompareTo("25")<=0) return true;
        else return false;
    }
}