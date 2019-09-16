public class Solution
{
    public int GetMaxGift(int[,] matrix)
    {
        if(matrix==null||matrix.GetLength(0)<=0||matrix.GetLength(1)<=0)
        {
            return 0;
        }

        int[] dp=new int[matrix.GetLength(1)];

        for(int i=0;i<matrix.GetLength(0);i++)
        {
            for(int j=0;j<matrix.GetLength(1);j++)
            {
                int left=0;
                int up=0;
                
                if(i>0)
                {
                    up=dp[j];
                }

                if(j>0)
                {
                    left=dp[j-1];
                }

                dp[j]=Math.Max(up,left)+matrix[i,j];
            }
        }

        return dp[dp.Length-1];
    }
}