public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max=0;
        int i=0;
        int j=0;

        HashSet<char> hash=new HashSet<char>();

        while(j<s.Length)
        {
            if(!hash.Contains(s[j]))
            {
                hash.Add(s[j]);
                j++;
                max=Math.Max(hash.Count,max);
            }
            else
            {
                hash.Remove(s[i]);
                i++;
            }
        }

        return max;
    }
}