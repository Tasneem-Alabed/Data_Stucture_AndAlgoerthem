using Stack_Queu;
namespace Test_Stack_Queu
{
    public class UnitTest1
    {
        Stack_Linked_List stack = new Stack_Linked_List();
        Queu queu = new Queu();
        [Fact]
        public void Push_One_Value()
        {
            stack.push(8);
            Assert.Equal(stack.Peek(), 8);
            
        }
        [Fact]
        public void Push_Two_Value()
        {
            stack.push(8);
            stack.push(12);
            
            Assert.Equal(stack.Peek(), 12);
            stack.pop();
            Assert.Equal(stack.Peek(), 8);

        }

        [Fact]
        public void Pop_One_Value()
        {
            stack.push(77);
            Assert.Equal(stack.pop(), 77);
            Assert.True(stack.Is_Empty());

        }
        [Fact]
        public void Pop_Tow_Value()
        {
            stack.push(77);
            stack.push(6);
            Assert.Equal(stack.pop(), 6);
            Assert.Equal(stack.pop(), 77);
            Assert.True(stack.Is_Empty());

        }
        [Fact]
        public void Peek_value()
        {
            stack.push(77);
            stack.push(6);
            Assert.Equal(stack.pop(), 6);
            Assert.Equal(stack.Peek(), 77);
           

        }

        [Fact]
        public void instantiate_Empty_Stack()
        {
            Assert.True(stack.Is_Empty());

            
        }

        [Fact]
        public void Stack_Raises_Exception_Peek()
        {
           

            Assert.Throws<NullReferenceException>(() =>stack.Peek());
        }

        [Fact]
        public void Stack_Raises_Exception_Pop()
        {
            Assert.Throws<NullReferenceException>(() => stack.pop());
        }

        [Fact]
        public void Enqueu_One_Value()
        {
            queu.Enqueue(1);
            Assert.Equal(queu.Peek(), 1);
        }
        [Fact]
        public void Enqueu_Tow_Value()
        {
            queu.Enqueue(1);
            queu.Enqueue(5);
            Assert.Equal(queu.Peek(), 1);
        }
        [Fact]
        public void Dequeu_One_value()
        {
            queu.Enqueue(1);
            queu.Enqueue(5);
            queu.Dequeue();
            Assert.Equal(queu.Peek(), 5);
        }

        [Fact]
        public void Dequeu_Peek()
        {
            queu.Enqueue(1);
            queu.Enqueue(5);
           
            Assert.Equal(queu.Peek(), 1);
        }
        [Fact]
        public void Dequeu_Tow_value()
        {
            queu.Enqueue(1);
            queu.Enqueue(5);
            queu.Dequeue();
            queu.Dequeue();
            Assert.True(queu.IsEmpty());
        }

        [Fact]
        public void instantiate_Empty_Queu()
        {
            Assert.True(queu.IsEmpty());


        }
        [Fact]
        public void Queu_Raises_Exception_Peek()
        {


            Assert.Throws<NullReferenceException>(() => queu.Peek());
        }

        [Fact]
        public void Queu_Raises_Exception_Pop()
        {
            Assert.Throws<NullReferenceException>(() => queu.Dequeue());
        }
    }
}