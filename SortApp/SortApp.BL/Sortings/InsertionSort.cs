using System;

namespace SortApp.BL.Sortings
{
	/// <summary>
	/// Providing insertion sort algorithm.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class InsertionSort<T> : Sorter<T> where T : IComparable<T>
	{
		/// <summary>
		/// Sorts array using insertion sort algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Incoming array for sorting.
		/// </param>
		public override void Sort(T[] arr)
		{
			if (arr == null)
				throw new ArgumentNullException(nameof(arr));

			for (int i = 1; i < arr.Length; i++)
			{
				for (int j = i; (j > 0) && (arr[j].CompareTo(arr[j - 1]) < 0); j--)
				{
					this.Swap(arr, j, j - 1);

					this.AddIteration(arr, j, j - 1);
				}
			}
		}
	}
}
