using System.Collections.Generic;

public class TNode
{
    public int val;
    public IList<TNode> children;

    public TNode() { }

    public TNode(int _val)
    {
        val = _val;
    }

    public TNode(int _val, IList<TNode> _children)
    {
        val = _val;
        children = _children;
    }
}