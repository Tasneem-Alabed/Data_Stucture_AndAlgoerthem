using System.Security.Cryptography.X509Certificates;

namespace Multi_bracket
{
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
            int lastOpeningIndex = -1;
            char[] bracketsTracker = new char[s.Length];

            foreach (char c in s)
            {
                if (IsOpeningBracket(c))
                {
                    bracketsTracker[++lastOpeningIndex] = c;
                }
                else if (IsClosingBracket(c))
                {
                    if (lastOpeningIndex < 0 )
                    {
                        char x = c;
                        throw  new Exception($"error unmatched opening {x} remaining");
                        return false;
                    }
                    else if( !AreMatchingBrackets(bracketsTracker[lastOpeningIndex], c))
                    {
                        char y = c;
                        throw new Exception($"error closing {bracketsTracker[++lastOpeningIndex]} Doesn’t match opening {y}");
                        return false;
                    }
                    lastOpeningIndex--;
                }
            }
            return lastOpeningIndex == -1;
        }
      
    }

   
   

    }



