using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

namespace PizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(-9);
            tree.Insert(15);
            tree.Insert(6);


            tree.TraverseInOrder(tree.root);
            Console.WriteLine("--------------------------");

            var x = tree.PutTreeInQueu(tree);
            foreach (Node n in x)
            {
                Console.WriteLine(n.data);
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
            public void TraverseInOrder(Node parent)
            {
                if (parent != null)
                {
                    TraverseInOrder(parent.left);
                    Console.Write(parent.data + " ");
                    TraverseInOrder(parent.right);
                }
            }

            public Queue<Node> PutTreeInQueu(BST tree)
            {
                Queue<Node> queue = new Queue<Node>();
                Queue<Node> queue1 = new Queue<Node>();
                if (tree.root != null)
                {
                    queue.Enqueue(tree.root);
                }
                Node poiter = queue.Peek();
                while (poiter.right != null || poiter.left != null)
                {
                    if (poiter.left != null)
                    {
                        queue.Enqueue(poiter.left);
                    }

                    if (poiter.right != null)
                    {
                        queue.Enqueue(poiter.right);
                    }
                    Node val = queue.Dequeue();
                    queue1.Enqueue(val);
                    poiter= queue.Peek();
                }
                while(queue.Count > 0)
                {
                    queue1.Enqueue(queue.Dequeue());
                }

                return queue1;
            }

            public BST putInNewStringTree(BST tree)
            {
                BST New_Tree = new BST();

                return New_Tree;
            }
        }
    }
}

