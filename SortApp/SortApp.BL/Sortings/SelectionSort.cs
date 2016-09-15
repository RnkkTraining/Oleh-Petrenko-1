using System;

namespace SortApp.BL.Sortings
{
	/// <summary>
	/// Providing selection sort algorithm.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SelectionSort<T> : Sorter<T> where T : IComparable<T>
	{
		/// <summary>
		/// Sorts array using selection sort algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Incoming array for sorting.
		/// </param>
		public override void Sort(T[] arr)
		{
			if (arr == null)
				throw new NullReferenceException(nameof(arr));

			for (int i = 0; i < arr.Length - 1; i++)
			{
				int min = i;

				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j].CompareTo(arr[min]) < 0)
					{
						min = j;
					}
				}

				this.Swap(arr, i, min);
			}
		}
	}
}
