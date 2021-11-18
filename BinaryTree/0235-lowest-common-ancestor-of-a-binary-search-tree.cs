
// 235. Lowest Common Ancestor of a Binary Search Tree
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
// Difficulty: Medium

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // Traverse Right child
        if (p.val > root.val && q.val > root.val) {
            return LowestCommonAncestor(root.right, p, q);
        }
        
        // Traverse Left Child
        if (p.val < root.val && q.val < root.val) {
            return LowestCommonAncestor(root.left, p, q);
        }
        
        return root;
    }
}
        