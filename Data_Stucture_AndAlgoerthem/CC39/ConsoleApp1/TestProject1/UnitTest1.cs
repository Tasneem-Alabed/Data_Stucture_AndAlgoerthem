using global::ConsoleApp1;
using System;
using Xunit;
namespace TestProject1
{
   

        public class GraphTests
        {
            [Fact]
            public void TestIsPathExists_PathExists()
            {
               Graph<string> graph = new Graph<string>();
                Vertex<string> A = graph.AddVertex("A");
                Vertex<string> B = graph.AddVertex("B");
                Vertex<string> C = graph.AddVertex("C");
                Vertex<string> D = graph.AddVertex("D");
                graph.AddUnDirectEdge(A, B);
                graph.AddUnDirectEdge(B, C);
                graph.AddUnDirectEdge(C, D);
                bool pathExists = graph.IsPathExists(A, D);
                Assert.True(pathExists);
            }

            [Fact]
            public void TestIsPathExists_NoPathExists()
            {
                // Arrange
                Graph<string> graph = new Graph<string>();
                Vertex<string> A = graph.AddVertex("A");
                Vertex<string> B = graph.AddVertex("B");
                Vertex<string> C = graph.AddVertex("C");
                Vertex<string> D = graph.AddVertex("D");

                graph.AddUnDirectEdge(A, B);
                graph.AddUnDirectEdge(B, C);

                // Act
                bool pathExists = graph.IsPathExists(A, D);

                // Assert
                Assert.False(pathExists);
            }

            [Fact]
            public void TestIsPathExists_SingleVertex()
            {
                // Arrange
                Graph<int> graph = new Graph<int>();
                Vertex<int> A = graph.AddVertex(1);

                // Act
                bool pathExists = graph.IsPathExists(A, A);

                // Assert
                Assert.True(pathExists);
            }

            [Fact]
            public void TestIsPathExists_NoEdges()
            {
                // Arrange
                Graph<int> graph = new Graph<int>();
                Vertex<int> A = graph.AddVertex(1);
                Vertex<int> B = graph.AddVertex(2);
                Vertex<int> C = graph.AddVertex(3);

                // Act
                bool pathExists = graph.IsPathExists(A, B);

                // Assert
                Assert.False(pathExists);
            }
        }
    }

