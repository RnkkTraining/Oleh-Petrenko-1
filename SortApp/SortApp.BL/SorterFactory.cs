using System;
using SortApp.BL.Sortings;

namespace SortApp.BL
{
	/// <summary>
	/// Represents sorter factory which provides the concrete sorter.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SorterFactory<T> where T : IComparable<T>
	{
		/// <summary>
		/// Returns concrete sorter implementation.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="algorithmKind">
		/// Incoming array as string.
		/// </param>
		public Sorter<T> CreateSorter(SortingAlgorithmKind algorithmKind)
		{
			if (algorithmKind == SortingAlgorithmKind.Bubble)
				return new BubbleSort<T>();
			if (algorithmKind == SortingAlgorithmKind.Insertion)
				return new InsertionSort<T>();
			if (algorithmKind == SortingAlgorithmKind.Selection)
				return new SelectionSort<T>();
			if (algorithmKind == SortingAlgorithmKind.Quick)
				return new QuickSort<T>();

			return new InsertionSort<T>();
		}
	}
}
