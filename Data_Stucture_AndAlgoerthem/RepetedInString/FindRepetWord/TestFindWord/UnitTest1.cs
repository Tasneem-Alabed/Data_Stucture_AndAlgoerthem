using FindRepetWord;
namespace TestFindWord
{
    public class UnitTest1
    {
        [Fact]
        public void Repeatedword()
        {
           
            var hash = new Hash(10);

          
            string repeatedWord = hash.repeatedword("This is a test. This  only a test.");

           
            Assert.Equal("This", repeatedWord);
        }
        [Fact]
        public void NoRepeatedword()
        {

            var hash = new Hash(10);


            string repeatedWord = hash.repeatedword("This is a test");


            Assert.Equal("No repeated Word", repeatedWord);
        }
    }
}