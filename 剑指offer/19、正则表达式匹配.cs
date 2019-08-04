public class solution
{
    public bool isMatch(string s,string p)
    {
        bool[,] dp=new bool[s.Length+1,p.Length+1];
        dp[0,0]=true;

        for(int i=1;i<s.Length;i++)
        {
            dp[i,0]=false;
        }

        for(int i=0;i<p.Length;i++)
        {
            dp[0,i+1]=p[i]=='*'&&dp[0,i-1];
        }

        for(int i=0;i<s.Length;i++)
        {
            for(int j=0;j<p.Length;j++)
            {
                if(s[i]==p[j]||p[j]=='.')
                {
                    dp[i+1,j+1]=dp[i,j];
                }

                if(p[j]=='*')
                {
                    if(p[j-1]!=s[i]&&p[j-1]!='.')
                    {
                        dp[i+1,j+1]=dp[i+1,j-1];
                    }
                    else
                    {
                        dp[i+1,j+1]=dp[i+1,j-1]||dp[i,j+1]||dp[i+1,j];
                    }
                }
            }
        }

        return dp[s.Length,p.Length];
    }
}