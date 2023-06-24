namespace array_binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int target = 23;

                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    return mid; 
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1;
                }
            }

            return "not found"; 
        }

    }
        }

       

    }
}
