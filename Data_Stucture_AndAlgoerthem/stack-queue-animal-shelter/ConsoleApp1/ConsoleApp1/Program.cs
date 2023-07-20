using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("cat", "oo");
            Animal b = new Animal("dog", "aa");
            Animal c = new Animal("cat", "yy");

            AnimalShelter s = new AnimalShelter();
            s.Enqueue(a);
            s.Enqueue(b);
            s.Enqueue(c);
           

            

            Console.WriteLine(s.Dequeue("cat").name);
            
            Console.WriteLine(s.Dequeue("cat").name);
            Console.WriteLine(s.Dequeue("dog").name);

        }
    }
    public class Animal
    {

        public string species { get; set; }
        public string name { get; set; }
        public Animal(string species, string name)
        {
            this.species = species;
            this.name = name;
        }
    }

        public class Node
        {
            public Animal animal;
            public Node next;
        public Node( Animal animal)
        {
            this.animal = animal;
            next = null;

        }
    
    }
   
      public class Stack
    {
       public Node tail;
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


            public void push(Animal animal)
            {
                Node n = new Node(animal);
                n.next = tail;
                tail = n;

            }

            public Animal pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException();
                }
                Animal number = tail.animal;
                tail = tail.next;
                return number;
            }

           
        }
    public class AnimalShelter
    {
        public Stack stack1;
        public Stack stack2;
        public AnimalShelter()
        {

            stack1 = new Stack();
            stack2 = new Stack();
        }
        public void Enqueue(Animal animal)
        {
            while (!stack2.IsEmpty())
            {
                stack1.push(stack2.pop());
            }
            stack1.push(animal);
        }
        public Animal Dequeue(string pref)
        {
            while (!stack1.IsEmpty())
            {
                stack2.push(stack1.pop());
            }

            while (!stack2.IsEmpty())
            {
                var animal = stack2.pop();
                if (animal.species == pref)
                {
                    return animal;
                }
                stack1.push(animal);
            }

            return null;
        }
    }



    }
