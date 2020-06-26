using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBFS_PrintAll();
            TestInorder_PrintAll();
            TestPreorder_PrintAll();
            TestPostorder_PrintAll();

            Console.ReadLine();
        }

        private static void TestPostorder_PrintAll()
        {
            Console.Write("\n Postorder: ");
            Node<int> n = CreateTestTree();
            Tree.Postorder_PrintAll(n);
        }

        private static void TestInorder_PrintAll()
        {
            Console.Write("\n Inorder: ");
            Node<int> n = CreateTestTree();
            Tree.Inorder_PrintAll(n);
        }

        private static void TestPreorder_PrintAll()
        {
            Console.Write("\n Preorder: ");
            Node<int> n = CreateTestTree();
            Tree.Preorder_PrintAll(n);
        }

        private static void TestBFS_PrintAll()
        {
            Console.Write("\n BFS: ");
            Node<int> n = CreateTestTree();
            Tree.BFS_PrintAll(n);
        }

        private static Node<int> CreateTestTree()
        {
            Node<int> node5 = new Node<int>() { Data = 5 };
            Node<int> node4 = new Node<int>() { Data = 4 };
            Node<int> node2 = new Node<int>() { Data = 2, RightNode = node5, LeftNode = node4 };
            Node<int> node3 = new Node<int>() { Data = 3 };
            Node<int> node1 = new Node<int>() { Data = 1, LeftNode = node2, RightNode = node3 };
            return node1;
        }
    }
}