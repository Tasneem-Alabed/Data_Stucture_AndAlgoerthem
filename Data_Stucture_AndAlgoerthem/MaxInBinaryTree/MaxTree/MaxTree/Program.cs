namespace MaxTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();
            b.Insert(50);
            b.Insert(30);
            b.Insert(70);
            b.Insert(20);
            b.Insert(40);
            b.Insert(60);

            b.TraversePreOrder(b.Root);
            Console.WriteLine("--------------------------");

            b.TraversePostOrder(b.Root);
            Console.WriteLine("--------------------------");

            b.TraverseInOrder(b.Root);
            Console.WriteLine("--------------------------");

            
            //Console.WriteLine(b.FindMax());
        }
    }
    public class Node
    {
        public int Value;

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree
    {
        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }
            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Value + " ");
                TraversePreOrder(parent.Left);
                TraversePreOrder(parent.Right);
            }
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.Left);
                Console.Write(parent.Value + " ");
                TraverseInOrder(parent.Right);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.Left);
                TraversePostOrder(parent.Right);
                Console.Write(parent.Value + " ");
            }
        }

        public int FindMax() 
        {
            if (Root == null)
            {
                throw new Exception("The tree is null");
            }
            if (Root.Right == null)
            {
                return Root.Value;
            }
            Node newRoot = Root;
            while(newRoot.Right != null)
            {

                newRoot = newRoot.Right;
            }
            return newRoot.Value;
        }
       

    }
}