using System;
using Xunit;

namespace ConsoleApp1.Tests
{
    public class TestProject1
    {
        [Fact]
        public void Insert_SingleValue_RootNotNull()
        {
        
            var bst = new BST();

           
            bst.Insert(5);

        
            Assert.NotNull(bst.root);
            Assert.Equal(5, bst.root.data);
        }

        [Fact]
        public void test2()
        {
           
            var bst = new BST();

          
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(7);

           
            Assert.NotNull(bst.root);
            Assert.Equal(5, bst.root.data);
            Assert.NotNull(bst.root.left);
            Assert.Equal(3, bst.root.left.data);
            Assert.NotNull(bst.root.right);
            Assert.Equal(7, bst.root.right.data);
        }

        [Fact]
        public void test3()
        {
      
            var bst1 = new BST();
            bst1.Insert(5);
            bst1.Insert(7);
            bst1.Insert(3);

            var bst2 = new BST();
            bst2.Insert(3);
            bst2.Insert(7);
            bst2.Insert(8);

      
            int[] commonValues = bst1.commonValue(bst1, bst2);

            Array.Sort(commonValues);
            int[] expected = {0, 3, 7 };
            Assert.Equal(expected, commonValues);
        }
    }
}
