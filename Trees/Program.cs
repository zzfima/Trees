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
            TestPreorder_Stack_PrintAll();

            TestPostorder_PrintAll();
            TestGetTreeHeight();
            TestPrintLevels();

            Console.ReadLine();
        }

        private static void TestPreorder_Stack_PrintAll()
        {
            Console.Write("\n Preorder(by Stack): \t");
            Node<int> n = CreateTestTree();
            Tree.Preorder_Stack_PrintAll(n);
        }

        private static void TestPrintLevels()
        {
            Console.WriteLine("\n Print levels: \t\t");
            Node<int> n = CreateTestTree();
            Tree.PrintAllLevels(n);
        }

        private static void TestGetTreeHeight()
        {
            Console.Write("\n Tree height: \t\t");
            Node<int> n = CreateTestTree();
            Console.Write(Tree.GetTreeHeight(n));
        }

        private static void TestPostorder_PrintAll()
        {
            Console.Write("\n Postorder: \t\t");
            Node<int> n = CreateTestTree();
            Tree.Postorder_PrintAll(n);
        }

        private static void TestInorder_PrintAll()
        {
            Console.Write("\n Inorder: \t\t");
            Node<int> n = CreateTestTree();
            Tree.Inorder_PrintAll(n);
        }

        private static void TestPreorder_PrintAll()
        {
            Console.Write("\n Preorder: \t\t");
            Node<int> n = CreateTestTree();
            Tree.Preorder_PrintAll(n);
        }

        private static void TestBFS_PrintAll()
        {
            Console.Write("\n BFS: \t\t\t");
            Node<int> n = CreateTestTree();
            Tree.BFS_ByQueue_PrintAll(n);
        }

        private static Node<int> CreateTestTree()
        {
            Node<int> node7 = new Node<int>() { Data = 30 };
            Node<int> node6 = new Node<int>() { Data = 45 };
            Node<int> node5 = new Node<int>() { Data = 40, LeftNode = node7, RightNode = node6 };

            Node<int> node4 = new Node<int>() { Data = 57 };
            Node<int> node3 = new Node<int>() { Data = 70 };
            Node<int> node2 = new Node<int>() { Data = 60, LeftNode = node4, RightNode = node3 };

            Node<int> node1 = new Node<int>() { Data = 50, LeftNode = node5, RightNode = node2 };
            return node1;
        }
    }
}