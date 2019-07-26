public class solution
{
    public long Fibonacci(int n)
    {
        int[] result={0,1};
        if(n<2)
        {
            return result[n];
        }

        long num1=0;
        long num2=1;
        long res=0;

        for(int i=2;i<=n;i++)
        {
            res=num1+num2;
            num1=num2;
            num2=res;
        }

        return res;
    }
}