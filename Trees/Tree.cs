using System;
using System.Collections.Generic;

namespace Trees
{
    internal class Tree
    {
        public static void BFS_ByQueue_PrintAll<T>(Node<T> headNode)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(headNode);

            while (queue.Count != 0)
            {
                Node<T> node = queue.Dequeue();
                Console.Write(node.Data + " ");
                if (node.LeftNode != null)
                    queue.Enqueue(node.LeftNode);
                if (node.RightNode != null)
                    queue.Enqueue(node.RightNode);
            }
        }

        public static void PrintAllLevels<T>(Node<T> n)
        {
            int treeHeight = GetTreeHeight(n);
            for (int levelNumber = 0; levelNumber < treeHeight; levelNumber++)
            {
                Console.WriteLine($"\n Level {levelNumber}");
                PrintGivenLevel(n, levelNumber);
            }
        }

        public static int GetTreeHeight<T>(Node<T> n)
        {
            if (n == null)
                return 0;

            int leftHeight = GetTreeHeight(n.LeftNode);
            int rightHeight = GetTreeHeight(n.RightNode);

            if (leftHeight > rightHeight)
                return leftHeight + 1;
            return rightHeight + 1;
        }


        public static void PrintGivenLevel<T>(Node<T> n, int levelNumber)
        {
            if (n == null)
                return;

            if (levelNumber == 0)
            {
                Console.Write(n.Data + " ");
            }
            else
            {
                PrintGivenLevel(n.LeftNode, levelNumber - 1);
                PrintGivenLevel(n.RightNode, levelNumber - 1);
            }

        }

        /// <summary>
        /// Inorder (Left, Root, Right)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        internal static void Inorder_PrintAll<T>(Node<T> n)
        {
            //base case
            if (n == null)
                return;

            //recursive case
            Inorder_PrintAll(n.LeftNode);
            Console.Write(n.Data + " ");
            Inorder_PrintAll(n.RightNode);
        }

        /// <summary>
        /// Preorder (Root, Left, Right)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        internal static void Preorder_PrintAll<T>(Node<T> n)
        {
            //base case
            if (n == null)
                return;

            //recursive case
            Console.Write(n.Data + " ");
            Preorder_PrintAll(n.LeftNode);
            Preorder_PrintAll(n.RightNode);
        }

        /// <summary>
        /// Preorder (Root, Left, Right)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        internal static void Preorder_Stack_PrintAll<T>(Node<T> n)
        {
            Stack<Node<T>> s = new Stack<Node<T>>();
            s.Push(n);

            while (s.Count != 0)
            {
                Node<T> nt = s.Pop();
                Console.Write(nt.Data + " ");

                if (nt.RightNode != null)
                    s.Push(nt.RightNode);
                if (nt.LeftNode != null)
                    s.Push(nt.LeftNode);
            }
        }

        /// <summary>
        /// Postorder(Left, Right, Root)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        internal static void Postorder_PrintAll<T>(Node<T> n)
        {
            //base case
            if (n == null)
                return;

            //recursive case
            Postorder_PrintAll(n.LeftNode);
            Postorder_PrintAll(n.RightNode);
            Console.Write(n.Data + " ");
        }

        internal static void Inorder_Stack_PrintAll<T>(Node<T> n)
        {
            Stack<Node<T>> s = new Stack<Node<T>>();
            s.Push(n);

            while (s.Count != 0)
            {
                Node<T> nt = s.Peek();
                if(nt.LeftNode!= null)
                {
                    s.Push(nt.LeftNode);
                    continue;
                }



                Console.Write(nt.Data + " ");

                if (nt.RightNode != null)
                    s.Push(nt.RightNode);
                if (nt.LeftNode != null)
                    s.Push(nt.LeftNode);
            }
        }
    }
}