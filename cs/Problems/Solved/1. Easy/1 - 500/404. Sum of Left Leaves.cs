public class Solution_404
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        var sum = 0;
        if (root == null) return sum;
        if (root.left == null) return sum + SumOfLeftLeaves(root.right);

        if (root.left.left == null && root.left.right == null)
            sum += root.left.val;

        return sum + SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
    }
}