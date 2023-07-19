using System.Globalization;

namespace stack_queue_pseudo
{
    public class Program
    {
        static void Main(string[] args)
        {
          
           

        }
    }

    public class Node
    {
        public int id;
        public Node next;
        public Node(int id)
        {
            this.id = id;
           next = null;
        }
        public Node()
        { 
        
        }

    }
  
   public class Stack
    {

        Node tail;

        public Stack()
        {
            tail = null;
        }

        public bool IsEmpty()
        {
            if (tail == null)
            {
                return true;
            }
            else
                return false;
        }
        public void push(int value)
        {
            Node n = new Node(value);
            n.next = tail;
            tail = n;

        }

        public int pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            int number = tail.id;
            tail=tail.next;
            return number;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            return tail.id;

        }


    }

    public class Queue
    {
      public Stack stack1;
        public Stack stack2;
        public Queue() {
        
        stack1 = new Stack();
        stack2 = new Stack();
        }
        public void Enqueue(int value)
        {
            while (! stack2.IsEmpty())
            {
                stack1.push(stack2.pop());
            }

            stack1.push(value);
        }

        public int Dequeue()
        {
            while (!stack1.IsEmpty())
            {
                stack2.push(stack1.pop());
            }

            return stack2.pop();
        }

      
    }

   
}

    
