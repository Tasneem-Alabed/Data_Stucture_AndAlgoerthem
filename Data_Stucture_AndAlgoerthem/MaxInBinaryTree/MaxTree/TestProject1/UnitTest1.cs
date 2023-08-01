using MaxTree;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void test_if_null_tree()
        {
            BinaryTree binaryTree = new BinaryTree();

            Assert.Throws<Exception>(() => binaryTree.FindMax());
        }

        [Fact]
        public void test_if_Just_Root()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(8);

            Assert.Equal(8, binaryTree.FindMax());
        }

        [Fact]
        public void find_Max()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(8);
            binaryTree.Insert(11);
            binaryTree.Insert(-90);
            binaryTree.Insert(49);
            binaryTree.Insert(1);
            binaryTree.Insert(0);
            binaryTree.Insert(20);

            Assert.Equal(49, binaryTree.FindMax());
        }
    }
}