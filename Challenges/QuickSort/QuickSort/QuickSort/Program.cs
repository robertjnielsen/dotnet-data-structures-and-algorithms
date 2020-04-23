using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play with Quick Sort!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The original array:");
            Console.WriteLine();

            int[] arr = { 8, 4, 23, 42, 16, 15 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("The sorted array:");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
        }

        /// <summary>
        /// Sorts an integer array in the Quick Sort fashion.
        /// </summary>
        /// <param name="arr">The array to sort.</param>
        /// <param name="left">The beginning of the array.</param>
        /// <param name="right">The end of the array.</param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            // Checks to see if there are multiple elements in the array.
            if (left < right)
            {
                // Defines a partition position to perform QuickSort on a left and right side of the Pivot.
                int position = Partition(arr, left, right);

                // Calls the QuickSort method on both the left and right sides of the array partition.
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
        }

        /// <summary>
        /// Determines the element to become the partition for recursive QuickSort method calls.
        /// </summary>
        /// <param name="arr">The array to sort through.</param>
        /// <param name="left">The beginning of the array.</param>
        /// <param name="right">The end of the array.</param>
        /// <returns>The number to become the partition.</returns>
        public static int Partition(int[] arr, int left, int right)
        {
            // Sets the pivot as the last element in the array.
            int pivot = arr[right];

            // Sets our low counter.
            int i = left - 1;

            // Iterate through our array.
            for (int j = left; j < right; j++)
            {
                // Checks if the current element is less than the pivot.
                // If true, increment our low counter, and swap the current
                // element of the loop with the element matching our low counter.
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, j, i);
                }
            }

            // After all elements have been compared, swap the element after our low counter with our pivot.
            Swap(arr, right, i + 1);

            // Returns our new parition value.
            return i + 1;
        }

        /// <summary>
        /// Swaps the given values within the array.
        /// </summary>
        /// <param name="arr">The array to perform swaps in.</param>
        /// <param name="j">The first value to swap.</param>
        /// <param name="i">The second value to swap.</param>
        public static void Swap(int[] arr, int j, int i)
        {
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }


    }
}
