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
        [Fact]
        public void append()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
            s.append(11);

            Assert.Equal(11, s.tail.Data);

        }
        [Fact]
        public void append2()
        {

            SLL s = new SLL();
            s.insert(99);
            s.insert(3);
            s.insert(10);
            s.append(11);
            s.append(15);
            Assert.Equal(15, s.tail.Data);

        }

        [Fact]
        public void insert_before()
        {

            SLL s = new SLL();
            
            s.insert(2);
            s.insert(3);
            s.insert_before(2,66);

            Assert.Equal(66, s.head.Next.Data);

        }
        [Fact]
        public void insert_before2()
        {

            SLL s = new SLL();

            s.insert(2);
           
            s.insert_before(2, 66);

            Assert.Equal(66, s.head.Data);

        }
        [Fact]
        public void insert_before3()
        {

            SLL s = new SLL();

            s.insert(2);

            s.insert_before(2, 66);
            s.insert_before(66, 9);
            Assert.Equal(9, s.head.Data);

        }
        [Fact]
        public void Initial_List()
        {

            SLL s = new SLL();

            s.insert(2);

            s.Initial_List(2, 9);
            Assert.Equal(9, s.head.Next.Data);

        }
        [Fact]
        public void Initial_List2()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);
            s.Initial_List(5, 9);
            Assert.Equal(9, s.head.Next.Next.Data);

        }
        [Fact]
        public void Initial_List3()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);
            s.Initial_List(2, 9);
            Assert.Equal(9, s.head.Next.Next.Next.Data);

        }
        [Fact]
        public void kthFromEnd()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);

            Assert.Equal(2, s.kthFromEnd(0)) ;

        }
        [Fact]
        public void kthFromEnd1()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);

            Assert.Equal(5, s.kthFromEnd(1));

        }
        [Fact]
        public void kthFromEnd2()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);

            Assert.Equal(0, s.kthFromEnd(5));

        }
        [Fact]
        public void kthFromEnd3()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);

            Assert.Equal(12, s.kthFromEnd(3));

        }
        [Fact]
        public void kthFromEnd4()
        {

            SLL s = new SLL();

            s.insert(2);
            s.insert(5);
            s.insert(12);

            Assert.Equal(0, s.kthFromEnd(-3));

        }

        [Fact]
        public void kthFromEnd5()
        {

            SLL s = new SLL();

            s.insert(2);
           

            Assert.Equal(2, s.kthFromEnd(0));

        }


    }
}