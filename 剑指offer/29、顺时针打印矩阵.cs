public class Solution
{
    public IList<int> SpriralOrder(int[,] matrix)
    {
        IList<int> res=new List<int>();
        if(matrix.GetLength(0)==0) return res;
        int m=matrix.GetLength(0)-1;
        int n=matrix.GetLength(1)-1;
        int row=0,col=0;
        int index=0;

        while(row<=m&&col<=n)
        {
            switch(intdex)
            {
                case 0:
                for(int i=col;i<=n;i++)
                {
                    res.Add(matrix[row,i]);
                }
                row++;
                break;
                case 1:
                for(int i=row;i<=m;i++)
                {
                    res.Add(matrix[i,n]);
                }
                n--;
                break;
                case 2:
                for(int i=n;i>=col;i--)
                {
                    res.Add(matrix[m,i]);
                }
                m--;
                break;
                case 3:
                for(int i=m;i>=row;i--)
                {
                    res.Add(matrix[i,col]);
                }
                col++;
                break;
            }

            index=(index+1)%4;
        }

        return res;
    }
}