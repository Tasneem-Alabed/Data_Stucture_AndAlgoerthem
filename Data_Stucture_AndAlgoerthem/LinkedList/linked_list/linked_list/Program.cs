
using System.Xml.Linq;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SLL n = new SLL();
            n.insert(5);
            n.insert(8);
            n.insert(21);

            n.tostring();

          if (n.includes(21))
            {
                Console.WriteLine(true);
            }
            else
            {
                    Console.WriteLine(false);
            }
        }
    }

    public class Node
    {
      public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }

    public class SLL
    {
       private Node head;
        private Node tail;

        public SLL()
        {
            head = null;
            tail = null;
        }
        public void insert(int value)
        {
            Node new_node = new Node(value);
            new_node.Next = head;
            head = new_node;
        }
        public void tostring()
        {
            Node temp;
            temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
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