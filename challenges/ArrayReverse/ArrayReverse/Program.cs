using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int[] ReverseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }
    }
}
