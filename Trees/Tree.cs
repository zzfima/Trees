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
    }
}