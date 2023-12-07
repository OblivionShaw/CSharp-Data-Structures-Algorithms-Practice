using System.Drawing;
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
            MessageBox.Show("" + result[0][0] + result[0][1] + result[0][2] +"\n\r" + result[1][0] + result[1][1] + result[1][2] + "\n\r" + result[2][0] + result[2][1] + result[2][2] + "\n\r");
        }
    }
}
