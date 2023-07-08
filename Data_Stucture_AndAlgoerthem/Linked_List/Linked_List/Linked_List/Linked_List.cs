using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace linked_List
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
        public Node()
        {

            Next = null;
        }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public void insert(int value)
        {
            Node new_node = new Node(value);
            if (head == null)
            {
                head = tail = new_node;
            }
            else
            {
                new_node.Next = head;
                head = new_node;
            }
        }
        public String Print()
        {
            String a = "";
            Node temp;
            temp = head;
            while (temp != null)
            {
                a += "{" + $"{temp.Data}" + "}" + "=>";

                temp = temp.Next;
            }

            a += $"Null";
            return a;
        }
        public bool includes(int value)
        {
            Node temp;
            temp = head;
            while (temp != null)
            {
                if (temp.Data == value)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;

        }


    }
}

