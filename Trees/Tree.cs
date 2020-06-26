using System;
using System.Collections.Generic;

namespace Trees
{
    internal class Tree
    {
        internal static void BFS_ByQueue_PrintAll<T>(Node<T> headNode)
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

        internal static void BFS_PrintAllSeparateLines<T>(Node<T> headNode)
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
    }
}