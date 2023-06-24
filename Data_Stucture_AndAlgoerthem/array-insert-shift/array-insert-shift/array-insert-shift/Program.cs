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
            else if (arr.Length == 1|| arr.Length ==3)
            {for (int i = 0; i < arr.Length; i++)
                {arr1[i] = arr[i];}
               arr1[arr.Length] = value;
                return arr1;}
            else if (arr.Length % 2 == 0 )
            {int number = arr.Length / 2;
                int cout = 0;
                for (int i = 0; i < arr1.Length; i++ )
                {if (i == number)
                 {arr1[i] = value;}
                 else{
                        arr1[i] = arr[cout];
                        cout++;}}
                return arr1;}
            else if (arr.Length % 2 != 0)
            {int number = (arr.Length-1 / 2)+2;
                int counter = 0;
                for (int i = 0; i < arr1.Length; i++)
                { if (i == number){
                        arr1[i] = value;}
                    else{
                        arr1[i] = arr[counter];
                        counter++;
                    }}
                return arr1;}
              return arr1;}
}
    }
