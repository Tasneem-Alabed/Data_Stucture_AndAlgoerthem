﻿namespace GraphDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
   
        public class Vertex<T>
        {
            public T Value { get; set; }

            public Vertex(T value)
            {
                Value = value;
            }
        }

        public class Edge<T>
        {
            public int Weight { get; set; }
            public Vertex<T> Vertex { get; set; }
        }
        public class Graph<T>
        {
            public Dictionary<Vertex<T>, List<Edge<T>>> List { get; set; }

            private int _size = 0;

            public Graph()
            {
               List = new Dictionary<Vertex<T>, List<Edge<T>>>();
            }

            public Vertex<T> AddVertex(T vertex)
            {
                Vertex<T> node = new Vertex<T>(vertex);

              List.Add(node, new List<Edge<T>>());

                _size++;

                return node;

            }

            public void AddDirectEdge(Vertex<T> a, Vertex<T> b)
            {
              List[a].Add(new Edge<T>
                {
                    Weight = 0,
                    Vertex = b,
                });

            }

            public void AddUnDirectEdge(Vertex<T> a, Vertex<T> b)
            {
                AddDirectEdge(a, b);
                AddDirectEdge(b, a);
            }

            public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
            {
                return List[vertex];
            }

            public void Print()
            {
                foreach (var item in List)
                {
                    Console.Write($"Vertex {item.Key.Value} =>");

                    foreach (var edge in item.Value)
                    {
                        Console.Write($"{edge.Vertex.Value} =>");
                    }

                    Console.WriteLine();
                }
            }
        }
    }

