public class Solution
{
    public void Permutation(string s,int index)
    {
        if(s.Length<=0) return;
        if(index==s.Length-1)
        {
            System.Console.WriteLine(s+" ");
        }
        else
        {
            for(int i=index;i<s.Length;i++)
            {
                if(isDuplicates(s,index,i))
                {
                    Swap(s[index],s[i]);
                    Permutation(s,index+1);
                    Swap(s[index],s[i]);
                }
            }
        }
    }

    public bool isDuplicates(string s,int start,int end)
    {
        for(;start<end;start++)
        {
            if(s[start]==s[end]) return false;
        }

        return true;
    }

    public void Swap(char a,char b)
    {
        char temp=a;
        a=b;
        b=temp;
    }
}