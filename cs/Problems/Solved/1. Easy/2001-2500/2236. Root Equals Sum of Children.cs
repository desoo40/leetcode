public class Solution_2236
{
    public bool CheckTree(TreeNode root)
    {
        return root.val == root.left.val + root.right.val;
    }
}