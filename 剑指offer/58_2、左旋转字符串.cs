public class Solution
{
    public string LeftRotateString(string s,int n)
    {
        if(string.IsNullOrEmpty(s)||n<=0||n>=s.Length)
        {
            return s;
        }

        char[] arr=s.ToCharArray();

        Reverse(arr,0,n-1);
        Reverse(arr,n,arr.Length-1);
        Reverse(arr,0,arr.Length-1);

        return new string(arr);
    }
}