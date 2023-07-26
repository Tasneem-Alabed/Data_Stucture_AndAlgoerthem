namespace Max_stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            s.Push(20);
            s.Push(401);
            s.Push(1);
            s.Push(-90);

          
            Console.WriteLine(s.MaxNumber());
        }
    }

    public class Node
    {
       public int number;
       public Node next;
        public Node() 
        { 
        
        }
        public Node(int value)
        {
            number = value;
            
        }
    }

    public class stack
    {
        Node tail;
        public  stack()
        {
             tail = null;
        }

        public bool IsEmpty()
        {
            if (tail ==null)
                return true;

            else
                return false;
        }

        public void Push(int value)
        {
            Node new_Node = new Node(value);
            new_Node.next=tail;
            tail = new_Node;

        }

        public int pop()
        {
            if (!IsEmpty())
            {
                int x = tail.number;
                tail = tail.next;
                return x;
            }
               

            else
                throw new Exception("The stack is null"); 
        }

        public int MaxNumber()
        {
            if (!IsEmpty()) 
            {
                int number1 = tail.number;
                Node pointer = tail;
                while (pointer != null)
                {
                    if(pointer.number > number1) 
                    {
                        number1 = pointer.number;
                    }
                    pointer = pointer.next;
                }
                return number1;
            }
            throw new Exception("The stack is null");

        }
    }

    
}