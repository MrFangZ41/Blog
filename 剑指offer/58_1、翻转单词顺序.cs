public class Solution
{
    //直接用StringBuilder翻转
    public string ReverseSentence1(string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }

        string[] arr=s.Split(' ');
        StringBuilder sb=new StringBuilder();

        for(int i=arr.Length-1;i>=0;i--)
        {
            sb.Append(arr[i]).Append("");
        }

        return sb.ToString();
    }

    //先整个翻转字符串，再逐个单词翻转
    public string ReverseSentence2(string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }

        char[] arr=s.ToCharArray();
        Reverse(arr,0,arr.Length-1);

        int lo=0;
        int hi=0;
        while(lo<arr.Length)
        {
            hi++;
            if(hi==arr.Length||arr[hi]==' ')
            {
                Reverse(arr,lo,hi-1);
                hi++;
                lo=hi;
            }
        }

        return new string(arr);
    }

    public void Reverse(char[] arr,int lo,int hi)
    {
        if(arr==null||arr.Length<=0||lo<0||hi>=arr.Length||lo>hi)
        {
            return;
        }

        char temp;

        while(lo<hi)
        {
            temp=arr[lo];
            arr[lo]=arr[hi];
            arr[hi]=temp;
            lo++;
            hi--;
        }
    }
}