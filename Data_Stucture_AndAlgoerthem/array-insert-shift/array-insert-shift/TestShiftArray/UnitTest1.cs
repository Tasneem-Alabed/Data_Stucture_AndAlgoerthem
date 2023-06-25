using array_insert_shift;

    namespace TestShiftArray
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int value =1;
            int[] arr = new int[0];
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = 1;
            var result = array_insert_shift.Program.insertShiftArray(arr , value);
            Assert.Equal(result, arr2);
            
        }
        [Fact]
        public void Test2()
        {
            int value = 1;
            int[] arr = new int[1];
            arr[0] = 5;
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = 5;
            arr2[1] = 1;
            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
        [Fact]
        public void Test3()
        {
            int value = 1;
            int[] arr = new int[4] {-9,6,3,0};
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = -9;
            arr2[1] = 6;
            arr2[2] = 1;
            arr2[3] = 3;
            arr2[4] = 0;
            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
        [Fact]
        public void Test4()
        {
            int value = 1;
            int[] arr = new int[2] { -9, 6 };
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = -9;
            arr2[1] = 1;
            arr2[2] = 6;
            
            
            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
        [Fact]
        public void Test5()
        {
            int value = 1;
            int[] arr = new int[3] { -9, 6,4 };
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = -9;
            arr2[1] = 6;
            arr2[2] = 4;
            arr2[3] = 1;

            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
    }
}