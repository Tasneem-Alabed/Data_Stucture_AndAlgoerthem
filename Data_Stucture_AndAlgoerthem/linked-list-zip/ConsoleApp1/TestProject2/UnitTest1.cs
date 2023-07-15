using linked_List;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestProject1
{
    public class UnitTest1
    {
        LinkedList s = new LinkedList();
        [Fact]
        public void ZipLists_ValidLists_ReturnsZippedList()
        {
           
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

           
            LinkedList result = s.ZipLists(list1, list2);

            Assert.NotNull(result);
            Assert.NotNull(result.Head);

          
            int[] expectedValues = { 1, 2, 3, 4, 5, 6 };
            Node current = result.Head;
            int index = 0;
            while (current != null)
            {
                Assert.Equal(expectedValues[index], current.Value);
                current = current.Next;
                index++;
            }
        }

        [Fact]
        public void ZipLists_EmptyList_ReturnsNonEmptyList()
        {
        
            LinkedList list1 = new LinkedList();

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

          
            LinkedList result = s.ZipLists(list1, list2);

         
          
            int[] expectedValues = { 2, 4, 6 };
            Node current = result.Head;
            int index = 0;
            while (current != null)
            {
                Assert.Equal(expectedValues[index], current.Value);
                current = current.Next;
                index++;
            }
        }

        [Fact]
        public void ZipLists_OneEmptyList_ReturnsNonEmptyList()
        {
          
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();

         
            LinkedList result = s.ZipLists(list1, list2);

         
            Assert.NotNull(result);
            Assert.NotNull(result.Head);

            int[] expectedValues = { 1, 3, 5 };
            Node current = result.Head;
            int index = 0;
            while (current != null)
            {
                Assert.Equal(expectedValues[index], current.Value);
                current = current.Next;
                index++;
            }

        }

    }
}









