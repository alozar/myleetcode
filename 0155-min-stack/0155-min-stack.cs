public class MinStack
{
    private readonly Stack<(int Value, int Minimum)> _stack;

    public MinStack()
    {
        _stack = new();
    }

    public void Push(int val)
    {
        int curMin = val;
        if (_stack.Count > 0 && _stack.Peek().Minimum < val)
        {
            curMin = _stack.Peek().Minimum;
        }
        _stack.Push((val, curMin));
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek().Value;
    }

    public int GetMin()
    {
        return _stack.Peek().Minimum;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */