public class Solution
{
    //下一个丑数一定是丑数M前的某一个丑数 *2，*3，*5得到的
    //乘积过后小于M的丑数不用考虑
    //则存在一个丑数T，T之前的丑数乘积后小于M，之后的大于M
    //设立三个指针p2,p3,p5，每次得到新的丑数后，更新指针
    //即找到新的T
    public int GetUglyNum(int n)
    {
        if(n<=0)
        {
            return 0;
        }

        int[] ugnum=new int[n];
        ugnum[0]=1;
        int nextindex=1;
        int p2=0;
        int p3=0;
        int p5=0;

        while(nextindex<n)
        {
            int min=Math.Min(Math.Min(ugnum[p2]*2,ugnum[p3]*3),ugnum[p5]*5);
            ugnum[nextindex]=min;

            while(ugnum[p2]*2<=ugnum[nextindex])
            {
                p2++;
            }
            while(ugnum[p3]*3<=ugnum[nextindex])
            {
                p3++;
            }
            while(ugnum[p5]*5<=ugnum[nextindex])
            {
                p5++;
            }

            nextindex++;
        }
    }
}