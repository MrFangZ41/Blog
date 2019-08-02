public class Solution
{
    //把整数n减去1，最右边的1变为0，而其后面的0都变为1，如1100减去1，变为1011
    //将n与n-1进行位与运算，相当于把最右的1变为0，如1100与1011进行位与得到1000
    public int NumberOfOne(int n)
    {
        int count=0;
        while(n)
        {
            count++;
            n=(n-1)&n;
        }

        return count;
    }
}