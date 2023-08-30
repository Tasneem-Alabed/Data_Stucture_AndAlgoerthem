using InsertionSort;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void sortedArray()
        {
            int[]arr = new int[] { 1, 2, 3 };
            var result =InsertionSort.Program.InsertionSort(arr);
            Assert.Equal(result, arr);
        }

        [Fact]
        public void NonSorted()
        {
            int[] arr = new int[] { 1, 10, 3, 89 ,-23 };
            var result = InsertionSort.Program.InsertionSort(arr);
            int[] arr2 = new int[] { -23, 1, 3, 10, 89 };
            Assert.Equal(result, arr2);
        }

        [Fact]
        public void repetedvalue()
        {
            int[] arr = new int[] { 1, 10, 3, 89, -23 , 1 , 3 };
            var result = InsertionSort.Program.InsertionSort(arr);
            int[] arr2 = new int[] { -23, 1,1,3, 3, 10, 89 };
            Assert.Equal(result, arr2);
        }

        [Fact]
        public void repetedvalueOrder()
        {
            int[] arr = new int[] { 1, 1, 3, 3, 34, 50, 54 };
            var result = InsertionSort.Program.InsertionSort(arr);
            int[] arr2 = new int[] { 1, 1, 3, 3, 34, 50, 54 };
            Assert.Equal(result, arr2);
        }
    }
}