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
            int value = 5;
            int[] arr = new int[4] {2,4,6,-8};
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = 2;
            arr2[1] = 4;
            arr2[2] = 5;
            arr2[3] = 6;
            arr2[4] = -8;
            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
        [Fact]
        public void Test4()
        {
            int value = 16;
            int[] arr = new int[5] { 42,8,15,23,42 };
            int[] arr2 = new int[arr.Length + 1];
            arr2[0] = 42;
            arr2[1] = 8;
            arr2[2] = 15;
            arr2[3] = 16;
            arr2[4] = 23;
            arr2[5] = 42;

            var result = array_insert_shift.Program.insertShiftArray(arr, value);
            Assert.Equal(result, arr2);
        }
     
    }
}