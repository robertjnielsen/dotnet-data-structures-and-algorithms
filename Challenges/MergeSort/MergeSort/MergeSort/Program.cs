using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Let's test Merge Sort!");
			Console.WriteLine();

			int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };

			Console.WriteLine();
			Console.Write("The original array is: [ ");
			for (int i = 0; i < arr.Length; i++)
			{
				if (i == arr.Length - 1)
				{
					Console.Write($"{arr[i]} ]");
					break;
				}
				Console.Write($"{arr[i]}, ");
			}
			Console.WriteLine();
			Console.WriteLine($"The original array Length is: {arr.Length}");

			Console.WriteLine();
			Console.WriteLine();

			MergeSort(arr);

			Console.Write("The sorted array is: [ ");
			for (int i = 0; i < arr.Length; i++)
			{
				if (i == arr.Length - 1)
				{
					Console.Write($"{arr[i]} ]");
					break;
				}
				Console.Write($"{arr[i]}, ");
			}
			Console.WriteLine();
			Console.WriteLine($"The sorted array Length is: {arr.Length}");

			Console.WriteLine();
			Console.WriteLine();
        }

		public static void MergeSort(int[] arr)
		{
			int n = arr.Length;
			if (n > 1)
			{
				int mid = n / 2;
				int[] left = arr[0..mid];
				int[] right = arr[mid..n];
				MergeSort(left);
				MergeSort(right);
				Merge(left, right, arr);
			}
		}

		public static void Merge(int[] left, int[] right, int[] arr)
		{
			int i = 0;
			int j = 0;
			int k = 0;

			while (i < left.Length && j < right.Length)
			{
				if (left[i] <= right[j])
				{
					arr[k] = left[i];
					i++;
				}
				else
				{
					arr[k] = right[j];
					j++;
				}
				k++;
			}
			if (i == left.Length)
			{
				// Set remaining arr to remaining right
				for (int x = k; x < arr.Length; x++)
				{
					arr[x] = right[j];
					j++;
				}
			}
			else
			{
				// Set remaining arr to remaining left
				for (int x = k; x < arr.Length; x++)
				{
					arr[x] = left[i];
					i++;
				}
			}
		}
	}
}
