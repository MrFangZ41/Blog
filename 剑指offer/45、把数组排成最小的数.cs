public class Solution
{
    /*我们定义如果
      mn<nm,则m<n
      mn=nm,则m=n
      mn>nm,则m>n*/

    //其中可能涉及到拼接好的数大于Int的范围，我们可以把数字转化成字符串处理
    public string PrintMinNumber(string[] arr)
    {
        if(arr==null||arr.Length<=0)
        {
            System.Console.WriteLine("Error");
        }

        QuickSort(arr,0,arr.Length-1);
        StringBuilder res=new StringBuilder();
        for(int i=0;i<arr.Length;i++)
        {
            res.Append(arr[i]);
        }
        
        return res.ToString();
    }

    //用快排,把定义中的“小数”放在前面
    public void QuickSort(string[] arr,int lo,int hi)
    {
        if(lo>=hi)
        {
            return;
        }

        int index=lo;

        for(int i=lo;i<hi;i++)
        {
            if(arr[i]==null||arr[hi]==null)
            {
                return;
            }
            if((arr[i]+arr[hi]).CompareTo(arr[hi]+arr[i])<0)
            {
                Swap(arr[i],arr[index]);
            }
        }

        Swap(arr[index],arr[hi]);
        QuickSort(arr,lo,index-1);
        QuickSort(arr,index+1,hi);
    }

    public void Swap(ref string a,ref string b)
    {
        string temp=a;
        a=b;
        b=temp;
    }
}
