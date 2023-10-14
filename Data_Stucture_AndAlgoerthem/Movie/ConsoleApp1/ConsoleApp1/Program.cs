using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            movie[] movies = new movie[5]
            {
                new movie { title = "A Movie", year = 2012, genres = new List<string> { "Action", "Adventure" } },
                new movie { title = "An Amazing Movie", year = 2011, genres = new List<string> { "Comedy", "Romance" } },
                new movie { title = "The bestest Movie", year = 2003, genres = new List<string> { "Drama", "Thriller" } },
                new movie { title = "Zelda", year = 2020, genres = new List<string> { "Sci-Fi", "Mystery" } },
                new movie { title = "Starfield", year = 2001, genres = new List<string> { "Horror", "Fantasy" } }
            };
            sort s = new sort();

            s.sortByTitle(movies);
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i].title + " " + movies[i].year);
            }
        }
    }

    public class movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public List<string> genres { get; set; }
    }

    public class sort
    {
        public sort()
        {

        }

        public movie[] sortByYear(movie[] movies)
        {
            movie key;
            movie cup;
            for (int i = 0; i < movies.Length - 1; i++)
            {
                key = movies[i];
                for (int j = i + 1; j < movies.Length; j++)
                {
                    if (key.year < movies[j].year)
                    {
                        movies[i] = movies[j];
                        movies[j] = key;
                    }
                }
            }

            return movies;
        }

        public movie[] sortByTitle(movie[] movies)
        {
            string[] skip = { "The", "An", "A" };

            for (int i = 0; i < movies.Length; i++)
            {
                for (int j = 0; j < movies.Length - 1; j++)
                {
                    string f = movies[j].title;
                    string s = movies[j + 1].title;
                    foreach (string n in skip)
                    {
                        f = f.Replace(n, " ");
                        s = s.Replace(n, " ");
                    }
                    if (Compare(f, s) > 0)
                    {
                        movie key = movies[j];
                        movies[j] = movies[j + 1];
                        movies[j + 1] = key;
                    }
                }
            }
            return movies;
        }

        public int Compare(string f, string s)
        {
            for (int i = 0; i < Math.Min(f.Length, s.Length); i++)
            {
                if (f[i] < s[i])
                {
                    return -1;
                }
                else if (f[i] > s[i])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
