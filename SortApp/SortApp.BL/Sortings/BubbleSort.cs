using System;

namespace SortApp.BL.Sortings
{
	/// <summary>
	/// Providing bubble sort algorithm.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class BubbleSort<T> : Sorter<T> where T : IComparable<T>
	{
		/// <summary>
		/// Sorts array using buble sort algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Incoming array for sorting.
		/// </param>
		public override void Sort(T[] arr)
		{
			if (arr == null)
				throw new ArgumentNullException(nameof(arr));

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j].CompareTo(arr[j + 1]) > 0)
					{
						this.Swap(arr, j, j + 1);
					}
				}
			}
		}
	}
}
