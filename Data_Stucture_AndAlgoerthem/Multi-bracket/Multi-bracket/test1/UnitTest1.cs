using Multi_bracket;
namespace test1
{
    public class UnitTest1
    {
        [Fact]
        public  void test1()
        {
            string a = "{ty}()";
            var result =Multi_bracket.Program.ValidateBrackets(a);
            Assert.True(result);
        }
        [Fact]
        public void test2()
        {
            string a = "{[]}";
            var result = Multi_bracket.Program.ValidateBrackets(a);
            Assert.True(result);
        }
        [Fact]
        public void test3()
        {
            string a = "()";
            var result = Multi_bracket.Program.ValidateBrackets(a);
            Assert.True(result);
        }

        [Fact]
        public void test4()
        {
            string a = "{ty})";
            //Exception e = new Exception($"error unmatched opening ) remaining");
            Assert.Throws < Exception> (() => Multi_bracket.Program.ValidateBrackets(a));
        }
        [Fact]
        public void test5()
        {
            string a = "{[})";
           // Exception e = new Exception("error closing [ Doesn’t match opening )");
            Assert.Throws<Exception>(() => Multi_bracket.Program.ValidateBrackets(a));
        }
    }

}
