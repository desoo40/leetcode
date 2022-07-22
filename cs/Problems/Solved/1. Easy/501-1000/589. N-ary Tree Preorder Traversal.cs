using System.Collections.Generic;

public class Solution
{
    public IList<int> Preorder(TNode root)
    {
        var ans = new List<int>();
        if (root == null) return ans;
        ans.Add(root.val);
        foreach (var node in root.children)
            ans.AddRange(Preorder(node));
        return ans;
    }
}