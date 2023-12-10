using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    internal class LinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        #region 141. Linked List Cycle 判斷Linked List中有無循環
        public bool HasCycleTwoPointer(ListNode head)
        {
            ListNode slow_pointer = head, fast_pointer = head;
            while (fast_pointer != null && fast_pointer.next != null)
            {
                slow_pointer = slow_pointer.next;
                fast_pointer = fast_pointer.next.next;
                if (slow_pointer == fast_pointer)
                {
                    return true;
                }
            }
            return false;
        }


        public bool HasCycleHashTable(ListNode head)
        {
            HashSet<ListNode> visited_nodes = new HashSet<ListNode>();
            ListNode current_node = head;
            while (current_node != null)
            {
                if (visited_nodes.Contains(current_node))
                {
                    return true;
                }
                visited_nodes.Add(current_node);
                current_node = current_node.next;
            }
            return false;
        }
        //快慢指針法：這種方法的優點是它不需要額外的空間，因此空間複雜度為 O(1)。
        //然而，它的缺點是如果鏈表中存在環，那麼它可能需要 O(n)
        //的時間才能找到環，其中 n是鏈表的長度。
        //哈希集合法：這種方法的優點是它可以在 O(n)的時間內找到環，其中 n
        //是鏈表的長度。然而，它的缺點是它需要 O(n)的額外空間來存儲訪問過的節點。

        //所以，哪種方法更好取決於你的需求。如果你關心空間複雜度，那麼快慢指針法可能更適合你。
        //如果你關心時間複雜度，那麼哈希集合法可能更適合你。

        #endregion


    }
}
