public class Solution_226 {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return null;
        
        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;

        if (root.left != null)
            root.left = InvertTree(root.left);
        
            
        if (root.right != null)
            root.right = InvertTree(root.right);

        return root;
    }
}