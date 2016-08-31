using System;
using System.Runtime.InteropServices;

namespace ToolBox.Algrithm
{
    public class MathAlgrithm
    {
        public int MaxSubSum(int[] a)
        {
            var thisSum = 0;
            var maxSum = 0;
            foreach (int t in a)
            {
                thisSum += t;
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
                else if (thisSum < 0)
                {
                    thisSum = 0;
                }
            }

            return maxSum;
        }

        #region For tree process
        public void RootFirstProcess(ClsNode root)
        {
            PrintNodeValue(root);
            if (root.Next != null)
            {
                RootFirstProcess(root.Next);
                if (root.Next.Slibing != null)
                {
                    RootFirstProcess(root.Next.Slibing);
                }
            }


        }

        public void MidProcess(ClsNode root)
        {
            if (root != null)
            {
                if (root.Next != null)
                {
                    MidProcess(root.Next);
                }
            }
            PrintNodeValue(root);

            if (root != null && (root.Next != null && root.Next.Slibing != null))
            {
                MidProcess(root.Next.Slibing);
            }
            
        }

        public void LastProcess(ClsNode root)
        {
            if (root.Next != null)
            {
                LastProcess(root.Next);
                if (root.Next.Slibing != null)
                {
                    LastProcess(root.Next.Slibing);
                }
            }
            PrintNodeValue(root);
        }

        private static void PrintNodeValue(ClsNode node)
        {
            Console.Write(node.NodeValue);
        }

        #endregion

        #region Hash

        int Hash(string str, int tableSize)
        {
            var hashVal = 0;
            for (var i = 0; i < str.Length; i++)
            {
                hashVal += str[i];
            }

            return hashVal % tableSize;
        }
        #endregion
    }

    public class BinaryTree
    {
        private ClsNode m_Root;
        public BinaryTree()
        {
            Init();
        }

        private void Init()
        {
            var lChild = new ClsNode{NodeValue = "+"};
            var rChild = new ClsNode{NodeValue = "-"};
            var l_lChild = new ClsNode
            {
                NodeValue = "1"
            };
            var l_rChild = new ClsNode
            {
                NodeValue = "2"
            };

            var r_lChild = new ClsNode
            {
                NodeValue = "5"
            };
            var r_rChild = new ClsNode
            {
                NodeValue = "4"
            };

            m_Root = new ClsNode { NodeValue = "+" };

            m_Root.Next = lChild;
            lChild.Slibing = rChild;
            lChild.Next = l_lChild;
            l_lChild.Slibing = l_rChild;

            rChild.Next = r_lChild;
            r_lChild.Slibing = r_rChild;
        }

        public ClsNode GetRoot()
        {
            return m_Root;
        }
    }
}
