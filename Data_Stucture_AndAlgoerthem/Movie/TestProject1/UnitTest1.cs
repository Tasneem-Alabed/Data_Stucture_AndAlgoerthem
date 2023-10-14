using ConsoleApp1;
namespace TestProject1

{
    public class UnitTest1
    {
      
        public class SortTests
        {
            [Fact]
            public void SortByYear_ShouldSortByYear()
            {
                // Arrange
                movie[] movies = new movie[]
                {
                new movie { title = "Movie A", year = 2010 },
                new movie { title = "Movie B", year = 2005 },
                new movie { title = "Movie C", year = 2020 },
                };

                sort s = new sort();

                // Act
                var sortedMovies = s.sortByYear(movies);

                // Assert
                Assert.Equal(2020, sortedMovies[0].year);
                Assert.Equal(2010, sortedMovies[1].year);
                Assert.Equal(2005, sortedMovies[2].year);
            }

            [Fact]
            public void SortByTitle_ShouldSortByTitle()
            {
                // Arrange
                movie[] movies = new movie[]
                {
                new movie { title = "C Movie", year = 2010 },
                new movie { title = "A Movie", year = 2005 },
                new movie { title = "B Movie", year = 2020 },
                };

                sort s = new sort();

                // Act
                var sortedMovies = s.sortByTitle(movies);

                // Assert
                Assert.Equal("A Movie", sortedMovies[0].title);
                Assert.Equal("B Movie", sortedMovies[1].title);
                Assert.Equal("C Movie", sortedMovies[2].title);
            }
        }
    }

}
