using System.Drawing;

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
            MessageBox.Show("二元搜尋Index=" + bs.Search(nums,target));
            target = 2;
            MessageBox.Show("二元搜尋Index=" + bs.Search(nums, target));
        }
    }
}
