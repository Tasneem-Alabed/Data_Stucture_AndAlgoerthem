namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 3, 9, 2, 4, 1, 5, 7, 8, 1 ,8 };
           
            Console.WriteLine("pp");
           // Console.WriteLine(MargeSort(arr).ToString());
           
            
        }
        public static int[] Marg(int[]arr , int[]left , int[] right)
        {
            int i=0, k =0, j = 0;
            while(i < left.Length && j<right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i=i+1;
                }

                else
                {
                    arr[k]= right[j];
                    j=j+1;
                }

                k = k+1;

            }
            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];

            return arr;
        }
        public static int[] MargeSort(int[] arr)
        {
            int n = arr.Length-1;
            int mid = n / 2;
            int []left = new int[mid ];
            int []right = new int [arr.Length];
            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            MargeSort(left);
            MargeSort (right);



            return Marg(arr, left, right);
        }
    }
}