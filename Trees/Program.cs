using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBFS_PrintAll();

            Console.ReadLine();
        }

        private static void TestBFS_PrintAll()
        {
            Node<int> node7 = new Node<int>() { Data = 7 };
            Node<int> node5 = new Node<int>() { Data = 5, LeftNode = node7 };
            Node<int> node4 = new Node<int>() { Data = 4, RightNode = node5 };
            Node<int> node6 = new Node<int>() { Data = 6 };
            Node<int> node3 = new Node<int>() { Data = 3, LeftNode = node4, RightNode = node6 };
            Node<int> node2 = new Node<int>() { Data = 2 };
            Node<int> node1 = new Node<int>() { Data = 1, LeftNode = node2, RightNode = node3 };

            Tree.BFS_PrintAll(node1);
        }
    }
}