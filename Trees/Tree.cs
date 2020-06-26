using System;
using System.Collections.Generic;

namespace Trees
{
    internal class Tree
    {
        internal static void BFS_PrintAll<T>(Node<T> headNode)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(headNode);

            while (queue.Count != 0)
            {
                Node<T> node = queue.Dequeue();
                Console.WriteLine(node.Data);
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

            //recursive case
            if (n.LeftNode != null)
                Inorder_PrintAll(n.LeftNode);

            Console.WriteLine(n.Data);

            if (n.RightNode != null)
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

            //recursive case
            Console.WriteLine(n.Data);

            if (n.LeftNode != null)
                Preorder_PrintAll(n.LeftNode);

            if (n.RightNode != null)
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

            //recursive case
            if (n.LeftNode != null)
                Preorder_PrintAll(n.LeftNode);

            if (n.RightNode != null)
                Preorder_PrintAll(n.RightNode);

            Console.WriteLine(n.Data);
        }
    }
}