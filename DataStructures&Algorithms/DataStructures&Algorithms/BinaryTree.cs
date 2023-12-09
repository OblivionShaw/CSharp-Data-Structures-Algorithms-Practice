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

        // 定義一個判斷平衡二元樹的函數
        public bool IsBalanced(TreeNode root)
        {
            // 如果根節點為空，則回傳true，因為空樹也是平衡二元樹
            if (root == null)
            {
                return true;
            }
            // 計算根節點的左右子樹的高度
            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);
            // 如果左右子樹的高度差超過1，則回傳false，因為不符合平衡二元樹的定義
            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return false;
            }
            // 如果左右子樹的高度差不超過1，則遞迴地檢查左右子樹是否也是平衡二元樹，並回傳結果
            return IsBalanced(root.left) && IsBalanced(root.right);

            //方法2
            //if(root == null) return true;
            //return Height(root) != -1;
        }

        // 定義一個計算節點高度的函數
        private int GetHeight(TreeNode node)
        {
            // 如果節點為空，則回傳0，因為空節點的高度為0
            if (node == null)
            {
                return 0;
            }
            // 如果節點不為空，則回傳1加上左右子節點的高度的最大值，因為節點的高度等於其子樹的高度加1
            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }

        //方法2
        private int Height(TreeNode root)
        {
            if (root == null) return 0;
            var leftHeight = Height(root.left);
            if (leftHeight == -1) return -1;
            var rightHeight = Height(root.right);

            if (rightHeight == -1) return -1;
            if (Math.Abs(leftHeight - rightHeight) > 1) return -1;
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
