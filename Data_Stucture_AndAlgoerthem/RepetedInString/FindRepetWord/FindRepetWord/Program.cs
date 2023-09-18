using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace FindRepetWord
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static string repeated_word(string Book)
        {
           if (string.IsNullOrEmpty(Book))
            {
                return Book;
            }

            else
            {
                string [] words = Book.Split(" "); 
                for(int couter =0; couter < words.Length; couter++) 
                {
                    string s1= words[couter];
                    for(int i = couter + 1; i < words.Length-1; i++)
                    {
                        string s2 = words[i];
                   var a=  s1?.Equals(s2,StringComparison.CurrentCultureIgnoreCase);
                        if(a==true)
                        {
                            return s1;
                        }                       
                    }
                }

            }
           return "";
        }
    }

}

