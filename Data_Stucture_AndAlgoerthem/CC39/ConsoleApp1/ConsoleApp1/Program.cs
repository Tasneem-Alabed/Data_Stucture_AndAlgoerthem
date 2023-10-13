namespace ConsoleApp1
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
        public Dictionary<Vertex<T>, List<Edge<T>>> graph { get; set; }

        private int _size = 0;

        public Graph()
        {
            graph = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T vertex)
        {
            Vertex<T> node = new Vertex<T>(vertex);

            graph.Add(node, new List<Edge<T>>());

            _size++;

            return node;

        }

        public void AddDirectEdge(Vertex<T> a, Vertex<T> b)
        {
            graph[a].Add(new Edge<T>
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
            return graph[vertex];
        }

        public void Print()
        {
            foreach (var item in graph)
            {
                Console.Write($"{item.Key.Value} =>");

                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value} =>");
                }

                Console.WriteLine();
            }

        }
        public bool IsPathExists(Vertex<T> startVertex, Vertex<T> endVertex)
        {
           
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>(); 
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            
            queue.Enqueue(startVertex);
            visited.Add(startVertex);
            while (queue.Count > 0)
            {
                Vertex<T> currentVertex = queue.Dequeue();

                
                if (currentVertex == endVertex)
                {
                    return true; 
                }

               
                List<Edge<T>> neighbors = GetNeighbors(currentVertex);
                foreach (var edge in neighbors)
                {
                    if (!visited.Contains(edge.Vertex))
                    {
                        queue.Enqueue(edge.Vertex);
                        visited.Add(edge.Vertex);
                    }
                }
            }
            return false;

        }
    }
}