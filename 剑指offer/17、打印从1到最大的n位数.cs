public class solution
{
    public void PrintToMax(int n)
    {
        if(n<=0)
        {
            return;
        }
        char[] res=new char[n+1];
        res[n]='0';
        for(int i=0;i<10;i++)
        {
            res[0]=i+'0';
            PrintRecursive(res,n,0);
        }
    }

    public void PrintRecursive(char[] num,int length,int index)
    {
        if(index==length-1)
        {
            PrintNum(num);
            return;
        }
        for(int i=0;i<10;i++)
        {
            num[index+1]=i+'0';
            PrintRecursive(num,length,index+1);
        }
    }

    public void PrintNum(char[] num)
    {
        bool isBeginingZero=true;
        for(int i=0;i<num.Length;i++)
        {
            if(num[i]!='0'&&isBeginingZero) isBeginingZero=false;
            if(!isBeginingZero) System.Console.WriteLine(num[i]);
        }

        System.Console.WriteLine("\t");
    }
}