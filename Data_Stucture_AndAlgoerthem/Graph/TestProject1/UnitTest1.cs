using GraphDemo;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void test1()
        {
            
            var graph = new Graph<int>();

           
            var vertex = graph.AddVertex(50);

           
            Assert.Contains(vertex, graph.List.Keys);
        }

        [Fact]
        public void test2()
        {
          
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);

           
            graph.AddDirectEdge(vertex1, vertex2);

           
            var edges = graph.GetNeighbors(vertex1);
            Assert.Contains(vertex2, edges.Select(e => e.Vertex));
        }

        [Fact]
        public void test3()
        {
           
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);

           
            graph.AddUnDirectEdge(vertex1, vertex2);

            
            var edges1 = graph.GetNeighbors(vertex1);
            var edges2 = graph.GetNeighbors(vertex2);
            Assert.Contains(vertex2, edges1.Select(e => e.Vertex));
            Assert.Contains(vertex1, edges2.Select(e => e.Vertex));
        }
    }

}