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
        
   public class AnimalShelter
    {
       public  Node head;
        public Node tail;
        public AnimalShelter()
        {
            head = null;
            tail = null;
        }
        public bool IsEmpty()
        {
            if(head == null)
                return true;
            else return false;
        }
        public void Enqueue(Animal animal)
        {
            Node node = new Node(animal);
            if (IsEmpty())
            {
                head = node;
                tail = node;
               
            }
            tail.next= node;
            tail = node;
        }
        public Animal Dequeue(string pref)
        {
          
                if (pref == "cat" || pref == "dog")
                {
                    Node n = head;
                    Node prev = null;

                   
                    while (n != null && n.animal.species != pref)
                    {
                        prev = n;
                        n = n.next;
                    }

                  
                    if (n != null)
                    {
                      
                        if (n == head)
                        {
                            head = n.next;
                        }
                    
                        if (n == tail)
                        {
                            tail = prev;
                        }
                      
                        if (prev != null)
                        {
                            prev.next = n.next;
                        }

                        n.next = null; 

                        return n.animal;
                    }
                }

                return null;
            }

        }
    }



    
