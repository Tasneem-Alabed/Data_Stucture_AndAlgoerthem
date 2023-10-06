using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;

namespace FindRepetWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word1 = "It was the best of times, it was the worst of times, it was the age of wisdom,";

            Hash n = new Hash(word1.Length);
           Console.WriteLine(n.repeatedword(word1));
        }

    }
    public class Node<T>
        {
            public T Value { get; set; }

            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }

        }

        public class LinkedList<T>
        {
            public LinkedList()
            {
            }

            public Node<T> head { get; set; }

            public LinkedList(T value)
            {
                Node<T> node = new Node<T>(value);
                head = node;
            }

            public void insert(T value)
            {
                Node<T> node = new Node<T>(value);

                node.Next = head;
                head = node;
            }
        }

        public class Hash
        {
            private LinkedList<KeyValuePair<string, string>>[] map { get; set; }
            public Hash(int size)
            {
                map = new LinkedList<KeyValuePair<string, string>>[size];
            }

            public int hash(string key)
            {
                int number = 0;

                char[] arr = key.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    number += arr[i];
                    number = (number * 599) % map.Length;
                }
                return number;

            }
            public void set(string key, string value)
            {
                int number = hash(key);
                if (map[number] == null)
                {
                    map[number] = new LinkedList<KeyValuePair<string, string>>();
                }

                KeyValuePair<string, string> Value = new KeyValuePair<string, string>(key, value);

                map[number].insert(Value);
            }

            public string get(string key)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] != null)
                    {
                        Node<KeyValuePair<string, string>> current = map[i].head;
                        while (current != null)
                        {
                            if (key == current.Value.Key)
                            {
                                return current.Value.Value;
                            }
                            current = current.Next;
                        }
                    }
                }
                return "Not Found";
            }

            public bool has(string key)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    if (map[i] != null)
                    {
                        Node<KeyValuePair<string, string>> current = map[i].head;
                        while (key != current.Value.Key)
                        {
                            current = current.Next;
                        }
                        if (key == current.Value.Key)
                        {
                            return true;
                        }
                    }

                }
                return false;
            }

            public string[] Keys()
            {
                List<string> keyList = new List<string>();

                for (int i = 0; i < map.Length; i++)
                {
                    Node<KeyValuePair<string, string>> current = map[i]?.head;

                    while (current != null)
                    {
                        keyList.Add(current.Value.Key);
                        current = current.Next;
                    }
                }

                return keyList.ToArray();
            }

        public Hash splits(string paregraph)
        {
            var hashsplit = new Hash(paregraph.Length);
            string[] n = paregraph.Split(" ");
           for(int i = 0; i < n.Length; i++)
            {
                
                hashsplit.set(n[i], n[i]);
            }

           return hashsplit;

        }
        public string repeatedword(string word)
        {
            var hashsplit = splits(word); 
            //string result;

            for (int i = 0; i < hashsplit.map.Length; i++)
            {
                Node<KeyValuePair<string, string>> current = hashsplit.map[i]?.head;

                while (current != null)
                {
                    Node<KeyValuePair<string, string>> prevous = current.Next;
                    while (prevous != null)
                    {
                        var a = current.Value.Value.Equals(prevous.Value.Value, StringComparison.CurrentCultureIgnoreCase);
                        if (a == true)
                        {
                            return current.Value.Value;
                        }
                        prevous = prevous.Next; 
                    }
                    current = current.Next;
                }
            }
            return "No repeated Word";
        }

    }

}





