public class MinStack
{
    int min;
    Stack<int> s=new Stack<int>();

    public MinStack()
    {
        min=int.MaxValue;
    }

    public void Push(int x)
    {
        //如果新值比最小值小，则先压入旧的最小值，再压入新值
        if(x<min)
        {
            s.Push(min);
            min=x;
        }

        s.Push(x);
    }

    public void Pop() 
    {
        //如果pop的值是最小值，则栈内的最小值将会改变
        //则pop两次（先pop新最小值，再pop旧最小值）
        if(s.Pop()==min)
        {
            min=s.Pop();
        }
    }
    
    public int Top() 
    {
        return s.Peek();
    }
    
    public int GetMin() 
    {
        return min;
    }
}
