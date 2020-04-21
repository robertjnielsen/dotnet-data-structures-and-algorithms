using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's sort an array with Insertion Sort!");
            Console.WriteLine();

            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine($"The inputted array is: [ {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]} ] ");

            int[] result = InsertionSort(arr);

            Console.WriteLine();
            Console.WriteLine($"The sorted array is: [ {result[0]}, {result[1]}, {result[2]}, {result[3]}, {result[4]}, {result[5]} ]");
        }

        /// <summary>
        /// Sorts an integer array with the Insertion Sort method.
        /// </summary>
        /// <param name="arr">The array to sort.</param>
        /// <returns>The original array, rebuilt and sorted.</returns>
        static int[] InsertionSort(int[] arr)
        {
            // Iterate for each element in the array but the first.
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int tmp = arr[i];

                // As long as true, shift elements forward one index moving backward in the array.
                while (j >= 0 && tmp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Set the final shifted value to the tmp where it fits in the sort.
                arr[j + 1] = tmp;
            }

            return arr;
        }
    }
}
