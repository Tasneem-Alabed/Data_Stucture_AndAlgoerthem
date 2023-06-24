using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linked_list
{
    internal class SSl
    {
        internal node head;


        public void insert(int value)
        {
            node new_node = new node(value);
            new_node.next = head;
            head = new_node;
        }

        public bool includes(int value)
        {
            node temp = new node(value);
            temp = this.head;
            while (temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    return true;
                }

            }
            return false;

        }
        public void tostring()
        {
            node temp;
            temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(head.data);
                temp = temp.next;
            }
        }

        public void append(int value)
        {
            node temp;
            temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
                if (temp.next.next == null)
                {
                    node new_node = new node(value);
                    temp.next = new_node;

                }


            }


        }

        public void insert_after(int  value,int number) {
            node temp = new node(value);
            
            node pointer;
            pointer = this.head;
            temp = this.head;
            while (temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                   while(pointer.next != temp)
                    {
                        pointer = pointer.next;
                        if(pointer.next.next == temp)
                        {
                            node input = new node(number);
                            pointer.next = input;
                            input.next = temp;
                        }
                    }
                }
            }
    }
}
