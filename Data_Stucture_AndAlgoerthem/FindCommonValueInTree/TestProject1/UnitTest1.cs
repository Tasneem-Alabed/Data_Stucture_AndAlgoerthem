using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            tree1.Insert(5);
            tree1.Insert(3);
            tree1.Insert(7);

            BinaryTree<int> tree2 = new BinaryTree<int>();
            tree2.Insert(5);
            tree2.Insert(4);
            tree2.Insert(7);

            TreeInterSection treeIntersection = new TreeInterSection();
            Hash<int, int> result = treeIntersection.tree_intersection(tree1, tree2);

           
            Assert.True(result.has(5));
            Assert.True(result.has(7));
            Assert.False(result.has(3)); 



        }
        [Fact]
        public void test2()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            tree1.Insert(2);
            tree1.Insert(4);
            tree1.Insert(6);

            BinaryTree<int> tree2 = new BinaryTree<int>();
            tree2.Insert(1);
            tree2.Insert(3);
            tree2.Insert(5);

            TreeInterSection treeIntersection = new TreeInterSection();
            Hash<int, int> result = treeIntersection.tree_intersection(tree1, tree2);

          
            Assert.Empty(result.Keys());
        }
        [Fact] 
        public void test3()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            tree1.Insert(5);
            tree1.Insert(3);
            tree1.Insert(7);

            BinaryTree<int> tree2 = new BinaryTree<int>(); 

            TreeInterSection treeIntersection = new TreeInterSection();
            Hash<int, int> result = treeIntersection.tree_intersection(tree1, tree2);

           
            Assert.Empty(result.Keys());
        }
    }
}