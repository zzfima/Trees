namespace Trees
{
    /// <summary>
    /// Defines a node of a tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> RightNode { get; set; }
        public Node<T> LeftNode { get; set; }
    }
}