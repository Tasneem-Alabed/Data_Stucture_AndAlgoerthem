namespace array_insert_shift
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[0];
            int value =1;
            insertShiftArray( arr, value);

        }

        public static Array insertShiftArray(int[] arr , int value){
           int[] arr1 = new int[arr.Length+1];
            if (arr==null){return null;}
               else if (arr.Length == 0){arr1[0] = value;
                return arr1;}
            int number = (arr.Length - 1)/2;
            for(int x = 0 , y = 0; x < arr1.Length; x++)
            {
                if (number+1 == x)
                {
                    arr1[x] = value;
                    
                }
                else
                {
                    arr1[x] = arr[y];
                    y++;
                }
            }
            
              return arr1;}
}
    }
