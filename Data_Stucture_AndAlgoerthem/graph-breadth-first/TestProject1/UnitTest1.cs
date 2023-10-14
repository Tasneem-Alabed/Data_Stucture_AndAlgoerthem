using ConsoleAp1;
namespace TestProject1
{
    public class UnitTest1
    {
        /*[Fact]
        public void test1()
        {
          
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");
            var vertexC = graph.AddVertex("C");
            var vertexD = graph.AddVertex("D");
            graph.AddUnDirectEdge(vertexA, vertexB);
            graph.AddUnDirectEdge(vertexA, vertexC);
            graph.AddUnDirectEdge(vertexB, vertexD);

            var traversal = graph.BreadthFirst(vertexA);
            Assert.Collection(traversal,
               vertex => Assert.Equal(vertexA, vertex),
               vertex => Assert.Equal(vertexB, vertex),
               vertex => Assert.Equal(vertexC, vertex),
               vertex => Assert.Equal(vertexD, vertex)
           );
        }

        [Fact]
        public void test2()
        {

            // Arrange
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("A");

            // Act
            var traversal = graph.BreadthFirst(vertexA);

            // Assert
            Assert.Collection(traversal, vertex => Assert.Equal(vertexA, vertex));
        }*/

        
        [Fact]
        public void test1()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            Vertex<string> vertexC = graph.AddVertex("C");

            graph.AddEdge(vertexA, vertexB, 5);
            graph.AddEdge(vertexB, vertexC, 3);
            graph.AddEdge(vertexA, vertexC, 10);

            int weightBetweenAandC = graph.CalculateTotalWeightBetweenVertices(vertexA, vertexC);
            Assert.Equal(8, weightBetweenAandC);
        }

        [Fact]
        public void test2()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            Vertex<string> vertexC = new Vertex<string>("C");

            // Attempt to calculate weight between a vertex not in the graph (vertexC).
            // This should throw an exception.
            Assert.Throws<ArgumentException>(() => graph.CalculateTotalWeightBetweenVertices(vertexA, vertexC));
        }
        [Fact]
        public void test3()
        {
            
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("A");
            var vertexB = graph.AddVertex("B");
            var vertexC = graph.AddVertex("C");
            var vertexD = graph.AddVertex("D");
            graph.AddEdge(vertexA, vertexB);
            graph.AddEdge(vertexA, vertexC);
            graph.AddEdge(vertexB, vertexD);

            
            var result = graph.DepthFirst(vertexA);

            
            Assert.Equal(new[] { vertexA, vertexB, vertexD, vertexC }, result);
        }
       
    }


}

