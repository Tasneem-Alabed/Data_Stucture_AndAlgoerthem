using BirthTree;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void nullTree()
        {
            BST t = new BST();
           // t.FirstBirth();
            Assert.False(t.FirstBirth() == null);
        }
        [Fact]
        public void oneValue()
        {
            BST t = new BST();
            t.Insert(5);
            List<int> p = new List<int>();
            p.Add(5);
            Assert.Equal(p , t.FirstBirth());
        }
       
        [Fact]
        public void moreValue()
        {
            BST t = new BST();
            t.Insert(5);
            t.Insert(6);
            t.Insert(1);
            List<int> p = new List<int>();
            p.Add(5);
            p.Add(1);
            p.Add(6);
            Assert.Equal(p, t.FirstBirth());
        }

    }
}