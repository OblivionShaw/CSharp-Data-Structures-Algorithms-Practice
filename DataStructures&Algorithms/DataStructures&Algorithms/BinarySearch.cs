using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    internal class BinarySearch
    {
        //二元搜尋 如果有目標則return目標Index 否則return-1
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                //(left+ right) / 2 
                //防止mid溢出使用以下
                int mid = left + (right - left) / 2;
                MessageBox.Show("left=" + left + " right=" + right + " mid=" + mid);
                if (nums[mid] == target)
                {
                    
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
