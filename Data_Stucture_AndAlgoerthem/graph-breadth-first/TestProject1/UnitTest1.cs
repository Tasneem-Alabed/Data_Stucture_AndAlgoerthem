using ConsoleAp1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
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
        }

    }

}