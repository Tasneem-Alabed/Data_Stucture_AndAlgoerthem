namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {

            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(6);
            b.Insert(1);
            b.Insert(2);
            b.Insert(11);

           // Console.WriteLine(b.Root.Left.Right.Value);
            b.TraversePreOrder(b.Root);
            Console.WriteLine("--------------------------");

            b.TraversePostOrder(b.Root);
            Console.WriteLine("--------------------------");

            b.TraverseInOrder(b.Root);
            Console.WriteLine("--------------------------");

            Console.WriteLine(b.Contains(2));

        }
    }

    public class Node
    {
        public int Value ;

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
       public  BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value) 
        {
           Root= InsertRec(Root, value);
        }
       
       private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }
            if(value < root.Value)
            {
               root.Left= InsertRec(root.Left, value);
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


            public bool Contains(int value)
        {
            Node NewRoot = Root;
            bool result = SearchValue(NewRoot, value);
            if(result)
            return result;

            return false;
        }

        private bool SearchValue(Node NewRoot, int value)
        {
            while (NewRoot != null)
            {
                if (NewRoot.Value == value)
                    return true;

                else if (NewRoot.Value > value)
                {
                    NewRoot = NewRoot.Left;
                    return SearchValue(NewRoot, value);
                }
                else if (NewRoot.Value < value)
                {
                    NewRoot = NewRoot.Right;
                    return SearchValue(NewRoot, value);
                }

            }
            return false;
        }

    }
  
}