using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
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

    public class SLL
    {
        public Node head;
        public Node tail;

        public SLL()
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

        public void append(int value)
        {
            Node node = new Node(value);
            Node pointer = new Node();
            pointer = head;
            while (pointer.Next != null)
            {
                if (pointer.Next.Next == null)
                {

                    pointer.Next = node;
                    tail = node;

                }
                pointer = pointer.Next;
            }
        }
        public void insert_before(int value, int newValue)
        {
            Node node = new Node(newValue);
            Node pointer;
            pointer = head;
            while (pointer != null)
            {
                if (pointer.Data == value)
                {
                    if (pointer == head)
                    {
                        node.Next = pointer;
                        head = node;


                    }
                    else
                    {
                        Node pointer2;
                        pointer2 = head;
                        while (pointer2.Next.Next != pointer)
                        {
                            if (pointer2.Next == pointer)
                            {
                                node.Next = pointer;
                                pointer2.Next = node;
                            }
                        }
                    }
                    break;

                }
                pointer = pointer.Next;



            }
            Console.WriteLine("No change, method exception");
        }

        public void Initial_List(int value, int newValue)
        {
            Node node = new Node(newValue);
            Node pointer;
            pointer = head;
            while (pointer != null)
            {
                if (pointer.Data == value)
                {
                    node.Next = pointer.Next;
                    pointer.Next = node;
                    break;
                }
                pointer = pointer.Next;
            }
            Console.WriteLine("No change, method exception");
        }

        public int kthFromEnd(int k)
        {
            int counter = 0;
            Node node;
            node = head;
            while (node != null)
            {
                counter++;
                node = node.Next;
                if (head== tail && k==0)
                {
                    return head.Data;
                }
                if (node.Next == null)
                {
                  
                    if(counter+1 == k)
                    {
                        return head.Data;
                    }
                    if (k < counter && k >= 0) {
                        
                        Node value;
                    value = head;
                    int leght = counter - k+1;
                        for (int i = 1; i < leght; i++)
                        {
                           
                            value = value.Next;
                            if (i == leght-1)
                            {
                                return value.Data;
                            }

                        }
                    }
                    break;
                }



            


            }
            return 0;
        }


    }
}

