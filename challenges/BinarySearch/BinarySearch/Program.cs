using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = { 1, 2, 3, 4, 5, 6, 7 };
            int key = 3;
            BinarySearch(binaryArray, key);
        }

        /// <summary>
        /// Iterates through an array, and searches for a specific element by a search key. Compares the current 'middle' location of the array to the key, and removes half of the array from the search depending on whether the key is greater than or less than the current middle element.
        /// </summary>
        /// <param name="arr">A sorted integer array to be iterated through.</param>
        /// <param name="key">The search key to match against an array element.</param>
        /// <returns>Returns the index of the matching array element. If no matching element exists, returns -1.</returns>
        public static int BinarySearch(int[] arr, int key)
        {
            // Declare left and right limit values.
            int left = 0;
            int right = arr.Length - 1;

            // Declare a loop that checks alters the left or right values
            // based on if the key is greater than / less than the current middle index.
            while (left < right)
            {
                // Declare the middle index value.
                int middle = (left + right) / 2;

                if (key > arr[middle])
                {
                    // Left becomes the middle index + 1.
                    left += middle++;
                }
                else if (key < arr[middle])
                {
                    // Right become the middle inxex - 1.
                    right = middle--;
                }
                else
                {
                    // The middle was found!
                    return middle;
                }
            }
            // We discovered the key wasn't an element.
            return -1;
        }
    }
}
