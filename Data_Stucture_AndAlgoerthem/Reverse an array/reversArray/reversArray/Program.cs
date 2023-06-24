namespace reversArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int [] arr1=new int[2];
            revers( arr1);
        }
        public static Array revers(int[] arr1)
        {
            if (arr1.Length == 0)
            {
                return null;
            }
            else if (arr1.Length == 1)
            {
                return arr1;
            }
            else if (arr1.Length >= 2)
            {
                int[] arr2 = new int[arr1.Length];
                for (int i = arr1.Length - 1; i >= 0; i--)
                {
                    arr2[arr1.Length - i - 1] = arr1[i];
                }
                return arr2;
            }
            return arr1;
        }
    }
}