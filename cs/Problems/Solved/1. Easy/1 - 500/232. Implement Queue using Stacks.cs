using System.Collections.Generic;

public class MyQueue
{

    public Stack<int> one;
    public Stack<int> two;
    public MyQueue()
    {
        one = new Stack<int>();
        two = new Stack<int>();
    }

    public void Push(int x)
    {
        if (Empty())
        {
            one.Push(x);
            return;
        }

        Reflow(one, two);
        one.Push(x);
        Reflow(two, one);

    }

    private void Reflow(Stack<int> lhs, Stack<int> rhs)
    {
        while (lhs.Count != 0)
            rhs.Push(lhs.Pop());
    }

    public int Pop()
    {
        if (one.Count != 0) return one.Pop();
        return -1;
    }

    public int Peek()
    {
        if (one.Count != 0) return one.Peek();
        return -1;
    }

    public bool Empty()
    {
        return one.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */