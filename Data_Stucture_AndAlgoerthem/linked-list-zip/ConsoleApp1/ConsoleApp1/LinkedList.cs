using System;
using System.Collections;
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
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }
        }
        public LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null)
            {
                return list2;
            }
            if (list2.Head == null)
            {
                return list1;
            }

            Node p1 = list1.Head;
            Node p2 = list2.Head;
            LinkedList result = new LinkedList();
            result.Head = p1;

            while (p1 != null && p2 != null)
            {
                Node temp1 = p1.Next;
                Node temp2 = p2.Next;
                p1.Next = p2;
                p2.Next = temp1;
                p1 = temp1;
                p2 = temp2;
            }

            if (p1 != null)
            {
                Node current = result.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = p1;
            }

          
            if (p2 != null)
            {
                Node current = result.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = p2;
            }

            return result;
        }


    }




}

