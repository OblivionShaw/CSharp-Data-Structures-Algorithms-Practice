using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    internal class StackQueue
    {
        #region 232. Implement Queue using Stacks 使用Stack做出Queue
        private Stack<int> Stack;
        private Stack<int> StackImpelemntQueue;

        public string GetStackStatus()
        {
            return string.Join(", ", Stack);
        }

        public string GetStackImpelemntQueue()
        {
            return string.Join(", ", StackImpelemntQueue);
        }

        public void QueueUsingStacks()
        {
            Stack = new Stack<int>();
            StackImpelemntQueue = new Stack<int>();
        }

        public void Push(int x)
        {
            Stack.Push(x);
        }

        public int Pop()
        {
            if (StackImpelemntQueue.Count == 0)
            {
                In2Out();
            }
            return StackImpelemntQueue.Pop();
        }

        public int Peek()
        {
            if (StackImpelemntQueue.Count == 0)
            {
                In2Out();
            }
            return StackImpelemntQueue.Peek();
        }

        public bool Empty()
        {
            return Stack.Count == 0 && StackImpelemntQueue.Count == 0;
        }

        private void In2Out()
        {
            while (Stack.Count > 0)
            {
                StackImpelemntQueue.Push(Stack.Pop());
            }
        }

        #endregion


    }


}
