using Tree;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckThatTreeIsNull()
        {
            BinaryTree b = new BinaryTree();
           
            Assert.Null(b.Root);
        }
        [Fact]
        public void TestAddToNullTree()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            Assert.NotNull(b.Root);
        }
        [Fact]
        public void TheSecondValueLessThanRootWilBeInLeft()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(3);
            Assert.Equal(3,b.Root.Left.Value);
        }

        [Fact]
        public void TheSecondValueBigThanRootWilBeInRight()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            Assert.Equal(7, b.Root.Right.Value);
        }

        [Fact]
        public void SearchValueIntheRoot()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result= b.Contains(5);
            Assert.True(result);
        }
        [Fact]
        public void SearchValueInthemiddelInLeft()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result = b.Contains(3);
            Assert.True(result);
        }

        [Fact]
        public void SearchValueInthemiddelInRight()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result = b.Contains(7);
            Assert.True(result);
        }

        [Fact]
        public void SearchValueIntheendInLeft()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result = b.Contains(-90);
            Assert.True(result);
        }
        [Fact]
        public void SearchValueIntheendInRight()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result = b.Contains(11);
            Assert.True(result);
        }

        [Fact]
        public void NoutFoundValue()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
            bool result = b.Contains(15);
            Assert.False(result);
        }
             [Fact]
        public void pre_order()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);
           
            Assert.Equal(5,5);
            Assert.Equal(3, 3);
            Assert.Equal(-90, -90);
            Assert.Equal(7, 7);
            Assert.Equal(11, 11);
           




        }
        [Fact]
        public void in_order()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);

            Assert.Equal(-90, -90);
            Assert.Equal(3, 3);
            Assert.Equal(11, 11);
                   
            
            Assert.Equal(7, 7);
            Assert.Equal(5, 5);

        }
        [Fact]
        public void post_order()
        {
            BinaryTree b = new BinaryTree();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(11);
            b.Insert(-90);

            Assert.Equal(-90, -90);
            Assert.Equal(3, 3);
            Assert.Equal(5, 5);
            Assert.Equal(7, 7);
            Assert.Equal(11, 11);


            
        }
    }
}