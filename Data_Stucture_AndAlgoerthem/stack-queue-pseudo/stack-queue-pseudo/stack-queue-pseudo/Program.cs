using System.Globalization;

namespace stack_queue_pseudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            pseudo_queue s = new pseudo_queue();
            s.push(5);
            s.push(6);
            s.push(7);

           


            Console.WriteLine("__________________________");
            Console.WriteLine("__________________________");
            Console.WriteLine("__________________________");

            
            
            s.enque(s.pop());
            s.enque(s.pop());
            s.enque(s.pop());




            Console.WriteLine(s.dequeue());
            Console.WriteLine(s.dequeue());
            Console.WriteLine(s.dequeue());





        }
    }

    public class node
    {
        public int id;
        public node next;
        public node(int id)
        {
            this.id = id;
           next = null;
        }
        public node()
        { 
        
        }

    }
    public class linked_list
    {
       public node head;
      public  node tail;

        public linked_list()
        {
            head = null;
            tail = null;
        }

        public bool IsEmpty() {
            if (head == null)
                return true;
            else
                return false;
        
        }

        public void add(int id) { 

        node node = new node(id);
            if (IsEmpty())
            {
                head = tail =node;
                
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public void print()
        {
            node current = head;
            while(current != null)
            {
                Console.WriteLine(current.id);

                current = current.next;
            }
        }
    }
    public class pseudo_queue
    {
        public linked_list s = new linked_list();
        public linked_list q = new linked_list();

        public void push(int id)
        {
            s.add(id);
           
        }

        public int pop()
        {
            if (s.IsEmpty())
            {
                throw new Exception();
            }
            node pointer = s.head;
          

            try
            {
                while (pointer != s.tail)
                {
                    if (pointer.next == s.tail)
                    {
                        int number = s.tail.id;
                        s.tail = pointer;
                        s.tail.next = null;
                       
                        return number;
                       
                    }
                    pointer = pointer.next;
                }
                int a = s.tail.id;
                s.tail = null;
                return a;
              

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int peek()
        {
            if (s.IsEmpty())
            {
                throw new Exception();
            }
            else 
                return s.tail.id;
        }
        public void enque(int value)
        {
            q.add(value);
        }

        public int dequeue()
        {
            if (q.IsEmpty())
            {
                throw new Exception();
            }
            node pointer = q.head;


            try
            {
                while (pointer != q.tail)
                {
                    if (pointer.next == q.tail)
                    {
                        int number = q.tail.id;
                        q.tail = pointer;
                        q.tail.next = null;

                        return number;

                    }
                    pointer = pointer.next;
                }
                int a = q.tail.id;
                q.tail = null;
                return a;


            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}