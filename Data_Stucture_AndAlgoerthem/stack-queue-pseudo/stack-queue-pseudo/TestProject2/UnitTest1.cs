using stack_queue_pseudo;
namespace TestProject2
{
    public class UnitTest1
    {

            [Fact]
            public void EnqueueAndDequeue()
            {
               
                pseudo_queue pq = new pseudo_queue();
                pq.push(5);
                pq.push(6);
                pq.push(7);

               
                pq.enque(pq.pop());
                pq.enque(pq.pop());
                pq.enque(pq.pop());

                
                Assert.Equal(5, pq.dequeue());
                Assert.Equal(6, pq.dequeue());
                Assert.Equal(7, pq.dequeue());
            }

            [Fact]
            public void Pop_FromEmptyQueue()
            {
                
                pseudo_queue pq = new pseudo_queue();

                
                Assert.Throws<Exception>(() => pq.pop());
            }

            [Fact]
            public void Dequeue_FromEmptyQueue()
            {
             
                pseudo_queue pq = new pseudo_queue();

               
                Assert.Throws<Exception>(() => pq.dequeue());
            }

            [Fact]
            public void Peek()
            {
            
                pseudo_queue pq = new pseudo_queue();
                pq.push(10);

                
                int peekValue = pq.peek();

               
                Assert.Equal(10, peekValue);
            }

            [Fact]
            public void Peek_FromEmptyQueue()
            {
              
                pseudo_queue pq = new pseudo_queue();

              
                Assert.Throws<Exception>(() => pq.peek());
            }
        }
    }

