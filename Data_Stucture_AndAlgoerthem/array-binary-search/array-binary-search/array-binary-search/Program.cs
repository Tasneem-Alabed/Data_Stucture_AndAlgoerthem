namespace array_binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        public static int binarySeacrh(int[] arr , int value) {
            int min = 0;
            int max = arr.Length-1;

            while(min <= max)
            {
                int mid = (min+max)/2;
                if (value == arr[mid])
                {
                    return mid;
                }
                else if(value < arr[mid])
                {
                    max= mid-1;
                }
                else if(value > arr[mid])
                {
                    min= mid+1;
                }

            }
            return - 1;
        }

    }

    
    
        
    

}
