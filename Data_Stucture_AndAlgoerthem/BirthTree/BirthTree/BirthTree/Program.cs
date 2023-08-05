using System.ComponentModel;

namespace BirthTree
{
    public class Program
    {
        static void Main(string[] args)
        {
          /*  BST tree = new BST();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(-9);
            tree.Insert(15);
            tree.Insert(10);


            //tree.FirstBirth();
            for (int i = 0; i < tree.FirstBirth().Count; i++)
            {
                Console.Write(tree.FirstBirth()[i]+" ");
            }*/

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
                
                int lheight = height(root.left);
                int rheight = height(root.right);

                
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
                printGivenLevel(root.left, level - 1,  Numbers);
                printGivenLevel(root.right, level - 1, Numbers);
            }
        }

       
    }
} 

    
 