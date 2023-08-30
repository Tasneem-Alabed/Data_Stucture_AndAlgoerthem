using System.ComponentModel;

namespace BirthTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BST t = new BST();
            t.Insert(5);
            t.Insert(7);
            t.Insert(3);
            t.Insert(6);
            t.Insert(4);
            t.Insert(1);
           t.Insert(2);

            t.FirstBirth();
            for (int i = 0; i < t.FirstBirth().Count; i++)
            {
                Console.Write(t.FirstBirth()[i] + " ");
            }

        }
    }
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

   public class BST
    {
       
        public Node root;
        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }
            if (value < root.data)
            {
                root.left = InsertRec(root.left, value);
            }
            else if (value > root.data)
            {
                root.right = InsertRec(root.right, value);
            }

            return root;
        }

        public void BinaryTree() 
        { 
            root = null;
        }

       
        public List<int>  FirstBirth()
        {
            List<int> Numbers = new List<int>();
            int h = height(root);
            
            for (int i = 1; i <= h; i++)
            {
                printGivenLevel(root, i , Numbers);
               // Console.WriteLine();
            }

            return Numbers;
        }

       
        public virtual int height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
               // Console.WriteLine("L");
                int lheight = height(root.left);
                //Console.WriteLine("L " + root.data +" " + lheight);
               // Console.WriteLine("R");
                int rheight = height(root.right);
                //Console.WriteLine("R " + root.data + " " + rheight);

                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }

       
        static void printGivenLevel(Node root, int level, List<int> Numbers)
        {
            
            if (root == null)
                throw new Exception();
            if (level == 1)
            {
                Numbers.Add(root.data);
            }
            else if (level > 1)
            {
                if(root.left != null)
                printGivenLevel(root.left, level - 1,  Numbers);
                if (root.right != null)
                printGivenLevel(root.right, level - 1, Numbers);
            }
        }

       
    }
} 

    
 