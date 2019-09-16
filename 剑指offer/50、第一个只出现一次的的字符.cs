public class Solution
{
    public char FindNotRepeatingChar(string s)
    {
        if(s=null||s.Length<=0)
        {
            throw new IndexOutOfRangeException();
        }

        Dictionary<char,int> dic=new Dictionary<char, int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!dic.ContainsKey(s[i]))
            {
                dic.Add(s[i],1);
            }
            else
            {
                int val=dic[s[i]];
                val++;
                dic[s[i]]=val;
            }
        }

        for(int i=0;i<s.Length;i++)
        {
            if(dic[s[i]]==1) return s[i];
        }

        return '0';
    }   
}