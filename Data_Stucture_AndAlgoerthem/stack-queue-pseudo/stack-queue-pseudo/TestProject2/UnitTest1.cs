using stack_queue_pseudo;
namespace TestProject2
{
    public class UnitTest1
    {
  
            [Fact]
            public void test1()
            {
             
                Queue queue = new Queue();

               
                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);

               
                Assert.Equal(10, queue.Dequeue());
                Assert.Equal(20, queue.Dequeue());
                Assert.Equal(30, queue.Dequeue());
            }

            [Fact]
            public void test2()
            {
        
                Queue queue = new Queue();

                Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
            }

            [Fact]
            public void test3()
            {
          
                Queue queue = new Queue();

             
                queue.Enqueue(5);
                queue.Enqueue(10);
                queue.Dequeue();
                queue.Enqueue(15);
                queue.Dequeue();

            
                Assert.Equal(15, queue.Dequeue());
            }

            [Fact]
            public void test14()
            {
              
                Stack stack = new Stack();

                stack.push(10);
                stack.push(20);
                stack.push(30);

               
                Assert.Equal(30, stack.pop());
                Assert.Equal(20, stack.pop());
                Assert.Equal(10, stack.pop());
            }

            [Fact]
            public void test15()
            {
              
                Stack stack = new Stack();

              
                Assert.Throws<InvalidOperationException>(() => stack.pop());
            }

            [Fact]
            public void test6()
            {
               
                Stack stack = new Stack();

              
                stack.push(42);

             
                Assert.Equal(42, stack.Peek());
            }

            [Fact]
            public void test7()
            {
        
                Stack stack = new Stack();

            
                Assert.Throws<InvalidOperationException>(() => stack.Peek());
            }
        }
    }



