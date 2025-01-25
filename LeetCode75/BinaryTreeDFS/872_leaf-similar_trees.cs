/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    void getAllLeafNodes(TreeNode node, List<int> leafNodes) {
        if (node == null) {
            return;
        }

        if (node.left == null && node.right == null) {
            leafNodes.Add(node.val);
        }
        else {
            getAllLeafNodes(node.left, leafNodes);
            getAllLeafNodes(node.right, leafNodes);
        }
    }

    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> root1LeafNodes = new List<int>();
        List<int> root2LeafNodes = new List<int>();
        
        getAllLeafNodes(root1, root1LeafNodes);
        getAllLeafNodes(root2, root2LeafNodes);

        return root1LeafNodes.SequenceEqual(root2LeafNodes);
    }
}
