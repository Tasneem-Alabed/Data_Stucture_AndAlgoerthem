namespace ConsoleAp1
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


        public void AddEdge(Vertex<T> vertex1, Vertex<T> vertex2, int weight = 0)
        {
            if (!List.ContainsKey(vertex1) || !List.ContainsKey(vertex2))
            {
                throw new ArgumentException("Both vertices should already be in the graph");
            }

           List[vertex1].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex2,
            });

            List[vertex2].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex1,
            });
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

        public List<Vertex<T>> BreadthFirst(Vertex<T> startVertex)
        {
            if (!List.ContainsKey(startVertex))
                throw new InvalidOperationException("this vertex is not in the graph");

            List<Vertex<T>> visitedNodes = new List<Vertex<T>>();
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                visitedNodes.Add(current);

                foreach (var edge in List[current])
                {
                    if (!visited.Contains(edge.Vertex))
                    {
                        visited.Add(edge.Vertex);
                        queue.Enqueue(edge.Vertex);
                    }
                }
            }
            return visitedNodes;
        }
        public int CalculateTotalWeightBetweenVertices(Vertex<T> startVertex, Vertex<T> endVertex)
        {
            if (!List.ContainsKey(startVertex) || !List.ContainsKey(endVertex))
            {
                throw new ArgumentException("Both vertices should already be in the graph");
            }


            Dictionary<Vertex<T>, int> distance = new Dictionary<Vertex<T>, int>();
            foreach (var vertex in List.Keys)
            {
                distance[vertex] = int.MaxValue;
            }
            distance[startVertex] = 0;

            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                foreach (var edge in List[current])
                {
                    if (distance[edge.Vertex] > distance[current] + edge.Weight)
                    {
                        distance[edge.Vertex] = distance[current] + edge.Weight;
                        queue.Enqueue(edge.Vertex);
                    }
                }
            }

        
            return distance[endVertex];
        }


    }
}