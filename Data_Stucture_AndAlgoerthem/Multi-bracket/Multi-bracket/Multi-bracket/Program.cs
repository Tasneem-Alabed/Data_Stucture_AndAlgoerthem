using System.Security.Cryptography.X509Certificates;

namespace Multi_bracket
{
    public class Node
    {
        public char number;
        public Node next;
        public Node()
        {

        }
        public Node(char value)
        {
            number = value;

        }
    }

    public class stack
    {
        Node tail;
        public stack()
        {
            tail = null;
        }

        public bool IsEmpty()
        {
            if (tail == null)
                return true;

            else
                return false;
        }

        public void Push(char value)
        {
            Node new_Node = new Node(value);
            new_Node.next = tail;
            tail = new_Node;

        }

        public char pop()
        {
            if (!IsEmpty())
            {
                char x = tail.number;
                tail = tail.next;
                return x;
            }


            else
                throw new Exception("The stack is null");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateBrackets("{}"));  // Output: True
            Console.WriteLine(ValidateBrackets("{}(){}"));  // Output: True
            Console.WriteLine(ValidateBrackets("()[[Extra Characters]]"));  // Output: True
            Console.WriteLine(ValidateBrackets("(){}[[]]"));  // Output: True
            Console.WriteLine(ValidateBrackets("{}{Code}[Fellows](())"));  // Output: True
            Console.WriteLine(ValidateBrackets("[({}]"));  // Output: False
            Console.WriteLine(ValidateBrackets("(]"));  // Output: False
            Console.WriteLine(ValidateBrackets("{(})"));  // Output: False

        }
        
        public static bool IsOpeningBracket(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        public static bool IsClosingBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
        private static bool AreMatchingBrackets(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '{' && closing == '}');
        }
        public static bool ValidateBrackets(string s)
        {
            stack b = new stack();
            int lastOpeningIndex = -1;
           // char[] bracketsTracker = new char[s.Length];

            foreach (char c in s)
            {
                if (IsOpeningBracket(c))
                {
                   b.Push(c);
                    lastOpeningIndex++;
                }
                else if (IsClosingBracket(c))
                {
                    if (lastOpeningIndex < 0 )
                    {
                        char x = c;
                        throw  new Exception($"error unmatched opening {x} remaining");
                        return false;
                    }
                    else if( !AreMatchingBrackets(b.pop(), c))
                    {
                        char y = c;
                        throw new Exception($"error closing {b.pop()} Doesn’t match opening {y}");
                        return false;
                    }
                    lastOpeningIndex--;
                }
            }
            return lastOpeningIndex == -1;
        }
      
    }
   



}



