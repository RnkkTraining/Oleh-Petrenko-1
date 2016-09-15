using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortApp.BL.Test.Sorting
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="SortApp.BL.Sortings.BubbleSort{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class BubbleSortTests
	{
		/// <summary>
		/// Performs a test towards the logics of bubble sort algorithm when incoming array is filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void BubbleSortFilledArray()
		{
			int[] originalArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			SortApp.BL.Sortings.Sorter<int> bubbleSorter = new SortApp.BL.Sortings.BubbleSort<int>();
			bubbleSorter.Sort(originalArray);

			CollectionAssert.AreEqual(expectedArray, originalArray);
		}

		/// <summary>
		/// Performs a test towards the logics of bubble sort algorithm when incoming array is empty.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void BubbleSortEmptyArray()
		{
			int[] originalArray = { };
			int[] expectedArray = { };

			SortApp.BL.Sortings.Sorter<int> bubbleSorter = new SortApp.BL.Sortings.BubbleSort<int>();
			bubbleSorter.Sort(originalArray);

			CollectionAssert.AreEqual(expectedArray, originalArray);
		}
	}
}
