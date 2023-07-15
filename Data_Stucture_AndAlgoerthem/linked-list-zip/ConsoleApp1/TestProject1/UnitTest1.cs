using LinkedList;
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
        public void zipLists()
        {
           

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


            Assert.Equal(test, s.zipLists(s, b));

        }
       

    }
}