using linked_List;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestProject1
{
    public class UnitTest1
    {
        LinkedList s = new LinkedList();
        LinkedList b = new LinkedList();
        LinkedList test = new LinkedList();

        [Fact]
        public void test1()
        {

            Assert.Null(s.head);
            Assert.Null(s.tail);

        }

        [Fact]
        public void test2()
        {


            s.insert(99);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test3()
        {


            s.insert(10);
            Assert.Equal(10, s.head.Data);
            Assert.NotNull(s.head);
            Assert.NotNull(s.tail);

        }
        [Fact]
        public void test4()
        {


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


            s.insert(99);
            s.insert(3);
            s.insert(10);

            Assert.False(s.includes(11));
            Assert.Equal(10, s.head.Data);


        }
        [Fact]
        public void test7()
        {


            s.insert(99);
            s.insert(3);
            s.insert(10);
            string expected = "{10}=>{3}=>{99}=>Null";

            Assert.Equal(expected, s.Print());



        }
        [Fact]
        public void test8()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);
            s.append(5);
            Assert.Equal(5, s.tail.Data);
          
        }
        [Fact]
        public void test9()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);
            s.append(5);
            s.append(51);
            Assert.Equal(51, s.tail.Data);

        }
        [Fact]
        public void test10()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);
            
            s.insert_before(10, 77);
            Assert.Equal(77, s.head.Data);

        }
        [Fact]
        public void test11()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);

            s.insert_before(10, 77);
            Assert.Equal(77, s.head.Data);

        }
        [Fact]
        public void test12()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);

            s.Initial_List(99, 77);
            Assert.Equal(77, s.tail.Next.Data);

        }
        [Fact]
        public void test13()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);

          
            Assert.Throws<IndexOutOfRangeException>(() => s.kthFromEnd(-1));

        }
    
    [Fact]
    public void test14()
    {

        s.insert(99);
        s.insert(3);
        s.insert(10);


        Assert.Throws<IndexOutOfRangeException>(() => s.kthFromEnd(51));

    }
        [Fact]
        public void test15()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);


            Assert.Equal(3, s.kthFromEnd(1));

        }
        [Fact]
        public void test16()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);


            Assert.Equal(99, s.kthFromEnd(0));

        }
        [Fact]
        public void test17()
        {

            s.insert(99);
            s.insert(3);
            s.insert(10);


            Assert.Equal(10, s.kthFromEnd(2));

        }
        /* [Fact]
         public void zipLists()
         {
             LinkedList s = new LinkedList();
             LinkedList b = new LinkedList();
             LinkedList test = new LinkedList();

             s.insert(99);
             s.insert(3);
             s.insert(10);

             b.insert(11);
             b.insert(77);
             b.insert(8);

             test.insert(10);
             test.insert(8);
             test.insert(3);
             test.insert(77);
             test.insert(99);
             test.insert(11);


             Assert.Equal(test, s.zipLists(s,b));

         }*/
        [Fact]
        public void ReversList()
        {
            LinkedList s = new LinkedList();
           

            s.insert(99);
            s.insert(3);
            s.insert(10);

            LinkedList test = new LinkedList();
            test.insert(10);
            test.insert(3);
            test.insert(9);

            Assert.Equal(test, s.ReversList(test));


        }

    }
}