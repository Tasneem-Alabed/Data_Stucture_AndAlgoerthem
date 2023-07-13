using System;

namespace Stack_Queu
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Queu queu = new Queu();
            Console.WriteLine(queu.IsEmpty());
            queu.Enqueue(1);
            //
            queu.Enqueue(2);
            queu.Enqueue(3);

            queu.Enqueue(4);

            queu.Dequeue();

            Console.WriteLine(queu.Dequeue());
            Console.WriteLine(queu.Dequeue());
            Console.WriteLine(queu.IsEmpty());
            Console.WriteLine(queu.Dequeue());
            Console.WriteLine(queu.Peek());*/
        }
    }

    public class Node
    {
        public Node next;
        public int Data;
        public Node(int value)
        {
            Data = value;
            next = null;
        }


    }

    public class Linked_List
    {
        public Node head;
        public Node tail;
        public Linked_List()
        {
            head = tail = null;
        }

        public void Add_To_Head(int value)
        {

            Node New_Node = new Node(value);

            if (head == null)
            {
                New_Node.next = null;
                head = tail = New_Node;


            }
            else
            {
                New_Node.next = head;
                head = New_Node;


            }

        }
        public void Add_To_Tail(int value)
        {

            Node New_Node = new Node(value);

            if (head == null)
            {
                Add_To_Head(value);
            }
            else
            {
                tail.next = New_Node;
                tail = New_Node;
            }

        }

        public void Print()
        {
            Node pointer = head;
            while (pointer != null)
            {
                Console.WriteLine(pointer.Data);
                pointer = pointer.next;
            }
        }

    }

    public class Stack_Linked_List
    {
        Linked_List Stack_List = new Linked_List();
        Node Top;

        public Stack_Linked_List()
        {
            Top = null;
        }

        public bool Is_Empty()
        {
            if (Top == null)
            {
                return true;
            }

            else
                return false;
        }

        public void push(int value)
        {

            Stack_List.Add_To_Tail(value);
            Top = Stack_List.tail;

        }

        public int pop()
        {
            int Out = Top.Data;
            try
            {

                if (Stack_List.head == Stack_List.tail)
                {
                    Top = null;

                    return Stack_List.tail.Data;
                }
                Node pointer = Stack_List.head;
                while (pointer != Stack_List.tail)
                {
                    if (pointer.next == Stack_List.tail)
                    {
                        Out = Stack_List.tail.Data;
                        Stack_List.tail = pointer;
                        Top = Stack_List.tail;
                        return Out;
                    }
                    pointer = pointer.next;

                }
                return Out;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public int Peek()
        {
            try
            {
                return Top.Data;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }
    }

    public class Queu
    {
        Linked_List Queu_Lisked_List = new Linked_List();
        Node Front;
        Node Back;

        public Queu()
        {
            Front = null;
            Back = null;

        }

        public bool IsEmpty()
        {
            if (Front == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Enqueue(int value)
        {
            if (IsEmpty())
            {
                Queu_Lisked_List.Add_To_Tail(value);
                Front = Queu_Lisked_List.head;
                Back = Queu_Lisked_List.tail;
            }
            Queu_Lisked_List.Add_To_Tail(value);

            Front = Queu_Lisked_List.head.next;
            Back = Queu_Lisked_List.tail;


        }

        public int Dequeue()
        {

            int Out;
            try
            {
                if (Front == Back)
                {
                    Out = Front.Data;
                    Front = Back = null;
                    return Out;
                }
                Out = Front.Data;
                Queu_Lisked_List.head = Queu_Lisked_List.head.next;
                Front = Queu_Lisked_List.head;

                return Out;

            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }

        }

        public int Peek()
        {

            try
            {
                return Front.Data;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }
    }

}