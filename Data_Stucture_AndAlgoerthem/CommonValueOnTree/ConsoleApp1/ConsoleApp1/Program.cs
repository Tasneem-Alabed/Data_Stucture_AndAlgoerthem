using System.Collections.Generic;
using System.Xml.Linq;


namespace ConsoleApp1
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

        public Node()
        {
            Left = null;
            Right = null;
        }
        public Node(T data)
        {
            Value = data;
            Left = null;
            Right = null;
        }

    }
    public class BinaryTree<T>
    {
        public Node<int> Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node<int> InsertRec(Node<int> root, int value)
        {
            if (root == null)
            {
                root = new Node<int>(value);
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
        public void TraversePreOrder(Node<int> parent)
        {
            if (parent != null)
            {
               Console.WriteLine(parent.Value);
                TraversePreOrder(parent.Left);
                TraversePreOrder(parent.Right);
            }
        }
        public T[] putInList(Node<T>? node, List<T> list)
        {
            if (node == null)
            { return new T[0]; }

            putInList(node.Left, list);
            list.Add(node.Value);
            putInList(node.Right, list);
            return list.ToArray();
        }

        public void TraverseInOrder(Node<int> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.Left);
                Console.Write(parent.Value + " ");
                TraverseInOrder(parent.Right);
            }
        }

        public void TraversePostOrder(Node<int> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.Left);
                TraversePostOrder(parent.Right);
                Console.Write(parent.Value + " ");
            }
        }
    }
        public class HashNode<Key, Value>
        {
            public Key key { get; set; }
            public IList<Value> value { get; set; }

            public HashNode(Key k, Value v)
            {
                key = k;
                value = new List<Value> { v };
            }
        }
            public class Hash<Key, Value>
            {
                public LinkedList<HashNode<Key, Value>>[] map { get; set; }
                public Hash(int size)
                {
                    map = new LinkedList<HashNode< Key, Value >>[size];
                }

                public int hash(Key key)
                {
                    int number = 0;

                    char[] arr = key.ToString().ToCharArray();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        number += arr[i];
                        number = number % map.Length;
                    }
                    return number;

                }
                public void set(Key key, Value value)
                {
                    int number = hash(key);
                    if (map[number] == null)
                    {
                        map[number] = new LinkedList<HashNode<Key, Value>>();
                    }

                    foreach (var x in map[number])
                    {
                        if (x.key.Equals(key))
                        {
                            x.value.Add(value);
                            return;
                        }
                    }

                    map[number].AddLast(new HashNode<Key, Value>(key, value));
                }

                public List<Value> get(Key key)
                {
                    int number = hash(key);
                    List<Value> values = new List<Value>();

                    if (map[number] != null)
                    {
                        foreach (var x in map[number])
                        {
                            if (x.key.Equals(key))
                            {
                                values.AddRange(x.value);
                            }
                        }
                    }
                    return values;
                }

                public bool has(Key key)
                {
                    int number = hash(key);
            if (map[number] != null)
            {
                foreach (var x in map[number])
                {
                    if (x.key.Equals(key))
                    {
                        return true;
                    }
                }


            }
                    return false;
                }
        public void Print()
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != null)
                {
                    foreach (var node in map[i])
                    {
                        Console.WriteLine(string.Join(" ", node.value));
                    }
                }
            }
        }
                public List<Key> Keys()
                {
                    List<Key> keyList = new List<Key>();


                    foreach (var x in map)
                    {
                        if (x != null)
                        {
                            foreach (var y in x)
                            {
                                keyList.Add(y.key);
                            }
                        }
                    }
                    return keyList;

                }



            }
            public class TreeInterSection
            {

                public Hash<int, int> tree_intersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
                {
                    
                    
                        if (tree1 == null || tree2 == null)
                        {
                            return new Hash<int, int>(100);
                        }

                        Hash<int, int> hash = new Hash<int,int>(100);
                        List<int> Tree1 = new List<int>();
                        List<int> Tree2 = new List<int>();
                        Hash<int, int> Result = new Hash<int,int>(100);

                        tree1.putInList(tree1.Root,Tree1);
                        foreach (var x in Tree1)
                        {
                            hash.set(x, x);
                        }

                        tree2.putInList(tree2.Root,Tree2);

                         foreach (var x in Tree2)
                        {
                            if (hash.has(x))
                            {
                                Result.set(x, x); 
                            }
                        }

                        return Result;
                    }
                }

            }
        
    
