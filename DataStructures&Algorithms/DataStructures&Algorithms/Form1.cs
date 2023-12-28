using System.Drawing;
using static DataStructures_Algorithms.LinkedList;
using static DataStructures_Algorithms.MeetingRooms;
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
            MessageBox.Show("�G���j�MIndex=" + bs.Search(nums, target));
            target = 2;
            MessageBox.Show("�G���j�MIndex=" + bs.Search(nums, target));
            nums = new int[] { 3, 5, 12, 16, 17, 26, 32, 51, 53, 64 };
            target = 32;
            MessageBox.Show("�G���j�MIndex=" + bs.Search(nums, target));

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
            BinaryTree bt = new BinaryTree();
            BinaryTree.TreeNode root = new BinaryTree.TreeNode(6);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(8);
            root.left.left = new BinaryTree.TreeNode(0);
            root.left.right = new BinaryTree.TreeNode(4);
            root.right.left = new BinaryTree.TreeNode(7);
            root.right.right = new BinaryTree.TreeNode(9);
            root.left.right.left = new BinaryTree.TreeNode(3);
            root.left.right.right = new BinaryTree.TreeNode(5);
            // ���Ȭ� p �M q ���`�I
            BinaryTree.TreeNode p = root.left;  // ���] p ���Ȭ� 2
            BinaryTree.TreeNode q = root.right;  // ���] q ���Ȭ� 8

            // �ե� LowestCommonAncestor ��k
            BinaryTree.TreeNode lca = bt.LowestCommonAncestor(root, p, q);

            // ��̧ܳC�@�P��������
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
            lca = bt.LowestCommonAncestor(root, p, q);
            MessageBox.Show(lca.val.ToString());


            root = new BinaryTree.TreeNode(2);
            root.left = new BinaryTree.TreeNode(1);
            p = root;  // p = 2
            q = root.left;  // q = 1
            lca = bt.LowestCommonAncestor(root, p, q);
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
            MessageBox.Show("�d��1�G����" + bs.IsBalanced(root));


            root = new BinaryTree.TreeNode(1);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(2);
            root.left.left = new BinaryTree.TreeNode(3);
            root.left.right = new BinaryTree.TreeNode(3);
            root.left.right.left = new BinaryTree.TreeNode(4);
            root.left.right.right = new BinaryTree.TreeNode(4);
            MessageBox.Show("�d��2�G����" + bs.IsBalanced(root));

            root = null;
            MessageBox.Show("�d��3�G����" + bs.IsBalanced(root));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            int pos = 1;
            // �Ы� ListNode ���
            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(-4);

            // �]�w next �ݩʥH�Φ����
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;  // �Ыؤ@�����A�ϱo node4 ���V node2
            MessageBox.Show("" + ll.HasCycleHashTable(node1));

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

        private void button7_Click(object sender, EventArgs e)
        {
            StackQueue sq = new StackQueue();
            sq.QueueUsingStacks();
            MessageBox.Show(sq.GetStackStatus());
            sq.Push(1);
            MessageBox.Show("Push�G" + sq.GetStackStatus());
            sq.Push(2);
            MessageBox.Show("Push�G" + sq.GetStackStatus());
            //sq.Peek();
            MessageBox.Show("Peek�G" + sq.Peek().ToString());
            MessageBox.Show(sq.GetStackImpelemntQueue());
            MessageBox.Show("Pop�G" + sq.Pop().ToString());
            //sq.Pop();
            MessageBox.Show(sq.GetStackImpelemntQueue());
            sq.Push(5);
            MessageBox.Show("Push�G" + sq.GetStackStatus() + sq.GetStackImpelemntQueue());
            sq.Empty();
            MessageBox.Show(sq.GetStackStatus());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ransomNote = "aa", magazine = "aab";


            int[] counts = new int[26];
            foreach (char c in magazine)
            {
                counts[c - 'a']++;
            }
            foreach (char c in ransomNote)
            {
                counts[c - 'a']--;
                if (counts[c - 'a'] < 0)
                    MessageBox.Show("�L�ŦX");
            }
            MessageBox.Show("�ŦX");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            int pos = 1;
            // �Ы� ListNode ���
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            MessageBox.Show(ll.PrintList(node1));
            node1 = ll.ReverseList(node1);
            MessageBox.Show(ll.PrintList(node1));
            node1 = ll.ReverseList2(node1);
            MessageBox.Show(ll.PrintList(node1));

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BinaryTree bt = new BinaryTree();
            BinaryTree.TreeNode root = new BinaryTree.TreeNode(1);
            root.left = new BinaryTree.TreeNode(2);
            root.right = new BinaryTree.TreeNode(3);
            root.left.left = new BinaryTree.TreeNode(4);
            root.left.right = new BinaryTree.TreeNode(5);
            MessageBox.Show("" + bt.DiameterOfBinaryTree(root));

            root = new BinaryTree.TreeNode(1);
            root.left = new BinaryTree.TreeNode(2);
            MessageBox.Show("" + bt.DiameterOfBinaryTree(root));

        }

        private void button11_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            ListNode result = ll.MiddleNode(node1);
            MessageBox.Show(ll.PrintList(result));


            ll = new LinkedList();
            node1 = new ListNode(1);
            node2 = new ListNode(2);
            node3 = new ListNode(3);
            node4 = new ListNode(4);
            node5 = new ListNode(5);
            ListNode node6 = new ListNode(6);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            result = ll.MiddleNode(node1);
            MessageBox.Show(ll.PrintList(result));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BinaryTree bt = new BinaryTree();
            BinaryTree.TreeNode root = new BinaryTree.TreeNode(3);
            root.left = new BinaryTree.TreeNode(9);
            root.right = new BinaryTree.TreeNode(20);
            root.right.left = new BinaryTree.TreeNode(15);
            root.right.right = new BinaryTree.TreeNode(7);
            MessageBox.Show("" + bt.MaxDepth(root));

            root = new BinaryTree.TreeNode(1);
            root.right = new BinaryTree.TreeNode(2);
            MessageBox.Show("" + bt.MaxDepth(root));

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MeetingRooms mr = new MeetingRooms();
            // �]�w�Ĥ@�ر��p����J
            Interval[] intervals1 = new Interval[] 
            {
            new Interval(0, 30),
            new Interval(5, 10),
            new Interval(15, 20)
            };

            // �ˬd�Ĥ@�ر��p�O�_�i�H�ѥ[�Ҧ��|ĳ
            MessageBox.Show(mr.CanAttendMeetings(intervals1).ToString());

            // �]�w�ĤG�ر��p����J
            Interval[] intervals2 = new Interval[] 
            {
            new Interval(7, 10),
            new Interval(2, 4)
            };

            // �ˬd�ĤG�ر��p�O�_�i�H�ѥ[�Ҧ��|ĳ
            MessageBox.Show(mr.CanAttendMeetings(intervals2).ToString());

        }
    }
}
