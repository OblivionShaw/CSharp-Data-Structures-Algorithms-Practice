using System.Drawing;
using static DataStructures_Algorithms.LinkedList;
using static System.Net.Mime.MediaTypeNames;

namespace DataStructures_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            BinarySearch bs = new BinarySearch();
            MessageBox.Show("二元搜尋Index=" + bs.Search(nums, target));
            target = 2;
            MessageBox.Show("二元搜尋Index=" + bs.Search(nums, target));
            nums = new int[] { 3, 5, 12, 16, 17, 26, 32, 51, 53, 64 };
            target = 32;
            MessageBox.Show("二元搜尋Index=" + bs.Search(nums, target));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepthFirstSearch DFS = new DepthFirstSearch();
            int[][] image = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
            int sr = 1, sc = 1, color = 2;
            int[][] result = new int[][] { };
            MessageBox.Show("" + image[0][0] + image[0][1] + image[0][2] + "\n\r" + image[1][0] + image[1][1] + image[1][2] + "\n\r" + image[2][0] + image[2][1] + image[2][2] + "\n\r");
            result = DFS.FloodFill(image, sr, sc, color);
            MessageBox.Show("" + result[0][0] + result[0][1] + result[0][2] + "\n\r" + result[1][0] + result[1][1] + result[1][2] + "\n\r" + result[2][0] + result[2][1] + result[2][2] + "\n\r");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet hs = new HashSet();
            int[] nums1 = [1, 2, 3], nums2 = [2, 4, 6];
            List<IList<int>> result = (List<IList<int>>)hs.FindDifference(nums1, nums2);
            string resultstring = "";

            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    resultstring += num + " ";
                }
                resultstring += "\n";
            }
            MessageBox.Show(resultstring);

            nums1 = [1, 2, 3, 3];
            nums2 = [1, 1, 2, 2];
            result = (List<IList<int>>)hs.FindDifference(nums1, nums2);
            resultstring = "";

            foreach (var list in result)
            {
                foreach (var num in list)
                {
                    resultstring += num + " ";
                }
                resultstring += "\n";
            }
            MessageBox.Show(resultstring);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryTree bs = new BinaryTree();
            BinaryTree.TreeNode root = new BinaryTree.TreeNode(6);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(8);
            root.left.left = new BinaryTree.TreeNode(0);
            root.left.right = new BinaryTree.TreeNode(4);
            root.right.left = new BinaryTree.TreeNode(7);
            root.right.right = new BinaryTree.TreeNode(9);
            root.left.right.left = new BinaryTree.TreeNode(3);
            root.left.right.right = new BinaryTree.TreeNode(5);
            // 找到值為 p 和 q 的節點
            BinaryTree.TreeNode p = root.left;  // 假設 p 的值為 2
            BinaryTree.TreeNode q = root.right;  // 假設 q 的值為 8

            // 調用 LowestCommonAncestor 方法
            BinaryTree.TreeNode lca = bs.LowestCommonAncestor(root, p, q);

            // 顯示最低共同祖先的值
            MessageBox.Show(lca.val.ToString());


            root = new BinaryTree.TreeNode(6);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(8);
            root.left.left = new BinaryTree.TreeNode(0);
            root.left.right = new BinaryTree.TreeNode(4);
            root.right.left = new BinaryTree.TreeNode(7);
            root.right.right = new BinaryTree.TreeNode(9);
            root.left.right.left = new BinaryTree.TreeNode(3);
            root.left.right.right = new BinaryTree.TreeNode(5);
            p = root.left;  // p = 2
            q = root.left.right;  // q = 4
            lca = bs.LowestCommonAncestor(root, p, q);
            MessageBox.Show(lca.val.ToString());


            root = new BinaryTree.TreeNode(2);
            root.left = new BinaryTree.TreeNode(1);
            p = root;  // p = 2
            q = root.left;  // q = 1
            lca = bs.LowestCommonAncestor(root, p, q);
            MessageBox.Show(lca.val.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinaryTree bs = new BinaryTree();
            BinaryTree.TreeNode root = new BinaryTree.TreeNode(3);
            root.left = new BinaryTree.TreeNode(9);
            root.right = new BinaryTree.TreeNode(20);
            root.right.left = new BinaryTree.TreeNode(15);
            root.right.right = new BinaryTree.TreeNode(7);
            MessageBox.Show("範例1二元樹為" + bs.IsBalanced(root));


            root = new BinaryTree.TreeNode(1);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(2);
            root.left.left = new BinaryTree.TreeNode(3);
            root.left.right = new BinaryTree.TreeNode(3);
            root.left.right.left = new BinaryTree.TreeNode(4);
            root.left.right.right = new BinaryTree.TreeNode(4);
            MessageBox.Show("範例2二元樹為" + bs.IsBalanced(root));

            root = null;
            MessageBox.Show("範例3二元樹為" + bs.IsBalanced(root));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            int pos = 1;
            // 創建 ListNode 實例
            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(-4);

            // 設定 next 屬性以形成鏈表
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;  // 創建一個環，使得 node4 指向 node2
            MessageBox.Show(""+ll.HasCycleHashTable(node1));

            ll = new LinkedList();
            node1 = new ListNode(1);
            node2 = new ListNode(2);
            node1.next = node2;
            node2.next = node1;
            MessageBox.Show("" + ll.HasCycleHashTable(node1));

            ll = new LinkedList();
            node1 = new ListNode(1);
            MessageBox.Show("" + ll.HasCycleHashTable(node1));

        }
    }
}
