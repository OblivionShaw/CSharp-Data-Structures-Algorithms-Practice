using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures_Algorithms
{
    internal class BinaryTree
    {
        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public TreeNode InvertTree(TreeNode root)
        {
            // Base Case
            if (root == null)
                return null;
            InvertTree(root.left); //Call the left substree
            InvertTree(root.right); //Call the right substree
                                    // Swap the nodes
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            return root; // Return the root
        }

        //這個問題可以使用遞迴或迭代的方式來解決。以下是一種使用遞迴的解法：
        //這個解法的基本思路是利用二元搜尋樹的性質：
        //對於任何節點，左子樹的所有節點的值都小於該節點的值，右子樹的所有節點的值都大於該節點的值。
        //因此，我們可以從根節點開始，如果 p 和 q 的值都大於根節點的值，
        //那麼最低共同祖先必定在右子樹；如果 p 和 q 的值都小於根節點的值，那麼最低共同祖先必定在左子樹。
        //如果 p 和 q 分別位於根節點的兩側，那麼根節點就是最低共同祖先。
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            // Value of current node or parent node.
            int parentVal = root.val;

            // Value of p
            int pVal = p.val;

            // Value of q;
            int qVal = q.val;

            if (pVal > parentVal && qVal > parentVal)
            {
                // If both p and q are greater than parent
                return LowestCommonAncestor(root.right, p, q);
            }
            else if (pVal < parentVal && qVal < parentVal)
            {
                // If both p and q are lesser than parent
                return LowestCommonAncestor(root.left, p, q);
            }
            else
            {
                // We have found the split point, i.e. the LCA node.
                return root;
            }
        }
    }
}
