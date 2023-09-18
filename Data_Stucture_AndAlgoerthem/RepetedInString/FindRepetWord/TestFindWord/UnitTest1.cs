using FindRepetWord;
namespace TestFindWord
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyString()
        {
            string word = "";
             
            var result = FindRepetWord.Program.repeated_word(word);

            Assert.Equal(word, result);

        }

        [Fact]
        public void testfindrepeted()
        {
            string word = "Once upon a time, there was a brave princess who...";

            var result = FindRepetWord.Program.repeated_word(word);

            Assert.Equal("a", result);

        }

        [Fact]
        public void testfindrepeted1()
        {
            string word = "It was the best of times, it was the worst of times, it was the age of wisdom," +
                " it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity," +
                " it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, " +
                "we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other" +
                " way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, " +
                "for good or for evil, in the superlative degree of comparison only...";

            var result = FindRepetWord.Program.repeated_word(word);

            Assert.Equal("It", result);

        }
        [Fact]
        public void testfindrepeted2()
        {
            string word = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            var result = FindRepetWord.Program.repeated_word(word);

            Assert.Equal("was", result);

        }

        [Fact]
        public void TestNoRepeted()
        {
            string word = "This code written to find the repeted word";

            var result = FindRepetWord.Program.repeated_word(word);

            Assert.Equal("", result);

        }
    }
}