using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    internal class HashSet
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            return new List<IList<int>> { new List<int>(set1.Except(set2)), new List<int>(set2.Except(set1)) };
        }

        //這種題目的確實可以使用哈希集合（HashSet）來解決，這是一種效率很高的方法。以下是一種使用 C# 和 HashSet 的解決方案：
        //這段程式碼首先將兩個輸入陣列轉換為 HashSet，這樣可以去除重複的元素並提供快速的查詢操作。
        //然後，我們使用 Except 方法來找出在一個集合中但不在另一個集合中的元素。這就是我們需要的答案。
        //這種方法的時間複雜度為 O(n)，其中 n 是兩個陣列的總長度。這是因為 HashSet 的插入和查詢操作的時間複雜度都是 O(1)。
        //因此，這種方法在效率上是相當好的。
    }
}
