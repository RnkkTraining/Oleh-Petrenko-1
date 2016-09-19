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
			switch (algorithmKind)
			{
				case SortingAlgorithmKind.Bubble:
					return new BubbleSort<T>();
				case SortingAlgorithmKind.Insertion:
					return new InsertionSort<T>();
				case SortingAlgorithmKind.Selection:
					return new SelectionSort<T>();
				case SortingAlgorithmKind.Quick:
					return new QuickSort<T>();
			}

			throw new NotSupportedException();
		}
	}
}
