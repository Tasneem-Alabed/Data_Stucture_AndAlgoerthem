using linked_list;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {

          SLL s = new SLL();
           
            Assert.Null(s.head);
            Assert.Null(s.tail);

        }

        [Fact]
        public void test2()
        {

            SLL s = new SLL();
            s.insert(99);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test3()
        {

            SLL s = new SLL();
           
            s.insert(10);
            Assert.Equal(10,s.head.Data);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test4()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
            Assert.Equal(10, s.head.Data);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test5()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
          
            Assert.True(s.includes(3));
            Assert.Equal(10, s.head.Data);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test6()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
         
            Assert.False(s.includes(11));
            Assert.Equal(10, s.head.Data);
           

        }
        [Fact]
        public void test7()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
            string expected = "{10}=>{3}=>{99}=>Null";
          
            Assert.Equal(expected,s.Print());
           
           

        }


    }
}