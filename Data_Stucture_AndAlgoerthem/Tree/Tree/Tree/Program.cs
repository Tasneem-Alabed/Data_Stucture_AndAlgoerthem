namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
           
           

        }
    }

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree<T>
    {
        public Node<T> Root;

        public BinaryTree()
        {
            Root = null;
        }

        public List<T> PreOrderTravarsel()
        {
            List<T> result = new List<T>();
            PreOrderTravarsel(Root, result);

            return result;
        }

        public void PreOrderTravarsel(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                result.Add(node.Value);

                PreOrderTravarsel(node.Left, result);

                PreOrderTravarsel(node.Right, result);
            }

        }

      
        public List<T> InorderTraversal()
        {
            List<T> result = new List<T>();
            InorderTraversal(Root, result);
            return result;
        }

        private void InorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Value);
                InorderTraversal(node.Right, result);
            }
        }

      
        public List<T> PostorderTraversal()
        {
            List<T> result = new List<T>();
            PostorderTraversal(Root, result);
            return result;
        }

        private void PostorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left, result);
                PostorderTraversal(node.Right, result);
                result.Add(node.Value);
            }
        }

    }

    public class BinarySeartchTree<T> : BinaryTree<T> where T : IComparable
    {

        public void Add(T value)
        {
            Root = AddNode(Root, value);
        }
        private Node<T> AddNode(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);


            if (value.CompareTo(node.Value) < 0)
                node.Left = AddNode(node.Left, value);

            else if (value.CompareTo(node.Value) > 0)
                node.Right = AddNode(node.Right, value);

            return node;
        }
    }
}