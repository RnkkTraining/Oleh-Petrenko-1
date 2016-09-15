using System;

namespace SortApp.BL.Sortings
{
	/// <summary>
	/// Base class for sorting algorithms.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public abstract class Sorter<T> where T : IComparable<T>
	{
		/// <summary>
		/// Implementing sorting algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Incoming array for sorting.
		/// </param>
		public abstract void Sort(T[] arr);

		/// <summary>
		/// Swap two elements.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// Array for swap elements.
		/// </param>
		/// <param name="firstIndex">
		/// Index of first element for swap.
		/// </param>
		/// <param name="secondIndex">
		/// Index of second element for swap.
		/// </param>
		protected void Swap(T[] arr, int firstIndex, int secondIndex)
		{
			T tmp = arr[firstIndex];
			arr[firstIndex] = arr[secondIndex];
			arr[secondIndex] = tmp;
		}
	}
}