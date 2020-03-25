using System;

namespace InsertShiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dummyArr = { 1, 2, 4, 5 };
            int dummyNum = 3;
            InsertShiftArray(dummyArr, dummyNum);
        }

        /// <summary>
        /// Takes in an array of integers, and a single integer. Places the single integer into the center of the array, and returns it as a new array.
        /// </summary>
        /// <param name="intArr">An array of integers.</param>
        /// <param name="num">An integer to be placed at the middle index of the array of integers.</param>
        /// <returns>A new array of integers with the single integer in the middle index.</returns>
        static int[] InsertShiftArray(int[] intArr, int num)
        {
            // Create new array to return.
            int[] newArr = new int[intArr.Length + 1];

            // Create value based on if param array is odd or even.
            int halfParamArray;
            if (intArr.Length % 2 == 0)
            {
                halfParamArray = intArr.Length / 2;
            }
            else
            {
                halfParamArray = intArr.Length / 2 + 1;
            }

            // Loop through first half of param array, assigning values to new array.
            for (int i = 0; i < halfParamArray; i++)
            {
                newArr[i] = intArr[i];
            }

            // Insert param number at halfway point of new array.
            int halfArr = newArr.Length / 2;
            newArr[halfArr] = num;

            // Loop through the second half of param array, assigning values to new array.
            for (int i = halfArr + 1; i < intArr.Length; i++)
            {
                newArr[i] = intArr[i - 1];
            }

            // Add final value of param array to end of new array.
            newArr[newArr.Length - 1] = intArr[intArr.Length - 1];

            // Return new array.
            return newArr;
        }
    }
}
