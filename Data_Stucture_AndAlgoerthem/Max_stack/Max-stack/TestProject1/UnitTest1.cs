using Max_stack;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            stack s = new stack();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            Assert.Equal(4, s.MaxNumber());
           

        }
        [Fact]
        public void Test2()
        {
            stack s = new stack();

            s.Push(15);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            Assert.Equal(15, s.MaxNumber());


        }
        [Fact]
        public void Test3()
        {
            stack s = new stack();

            s.Push(1);
            s.Push(21);
            s.Push(3);
            s.Push(4);

            Assert.Equal(21, s.MaxNumber());


        }

        [Fact]
        public void Test4()
        {
            stack s = new stack();

            s.Push(1);
            s.Push(2);
            s.Push(33);
            s.Push(4);

            Assert.Equal(33, s.MaxNumber());


        }

        [Fact]
        public void Test5()
        {
            stack s = new stack();



            Assert.Throws<Exception>(() => s.MaxNumber());

        }
    }
}