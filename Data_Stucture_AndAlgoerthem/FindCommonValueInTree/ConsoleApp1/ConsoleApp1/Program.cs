using System.ComponentModel;
using System.ComponentModel.Design;

namespace ConsoleApp1
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

            BST h = new BST();
            h.Insert(90);
            h.Insert(7);
            h.Insert(3);

       foreach (int i in h.commonValue(t,h))
            {
                Console.WriteLine(i);
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

        public int[] ToArray()
        {
            List<int> result = new List<int>();
            InOrderTraversal(root, result);
            return result.ToArray();
        }

        private void InOrderTraversal(Node node, List<int> result)
        {
            if (node == null)
                return;

            InOrderTraversal(node.left, result);
            result.Add(node.data);
            InOrderTraversal(node.right, result);
        }

        public  int[] commonValue(BST a , BST b)
        {
            int counter = 0;
            int[] result;
           int [] l1 =a.ToArray();
            int[] l2 =b.ToArray();
            if (l1.Length > l2.Length)
            {
                result = new int[l2.Length];

                for (int i = 0; i < l1.Length; i++)
                {
                    int key = l1[i];
                    for (int j = 0; j < l2.Length; j++)
                    {
                        if (key == l2[j])
                        {
                            result[counter] = key;
                            counter++;

                        }
                    }
                }
            }
            else { 
              result = new int[l1.Length];

            for (int i = 0; i < l1.Length; i++)
            {
                int key= l1[i];
                    for (int j = 0; j < l2.Length; j++)
                    {
                        if (key == l2[j])
                        {
                            result[counter] = key;
                            counter++;

                        }
                    }
                }
            }
            return result;
        }
    }
}


