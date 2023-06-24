using Microsoft.VisualStudio.TestPlatform.TestHost;
using reversArray;
namespace reversArrayTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[3] {2,3,4};
            int[] arr2 = new int[3] {4,3,2};
            var result = reversArray.Program.revers(arr);

            Assert.Equal(arr2, result);
        }
        [Fact]
        public void Test2()
        {
            int[] arr= new int[0] ;
            
            var result = reversArray.Program.revers(arr);

            Assert.Equal(null, result);
        }
        [Fact]
        public void Test3()
        {
            int[] arr = new int[1] { 2};
           
            var result = reversArray.Program.revers(arr);

            Assert.Equal(arr, result);
        }
    }
}