﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortApp.BL.Test.Sorting
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="SortApp.BL.Sortings.InsertionSort{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class InsertionSortTests
	{
		/// <summary>
		/// Performs a test towards the logics of insertion sort algorithm when incoming array is filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void InsertionSortFilledArray()
		{
			int[] originalArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			SortApp.BL.Sortings.Sorter<int> insertionSorter = new SortApp.BL.Sortings.InsertionSort<int>();
			insertionSorter.Sort(originalArray);

			CollectionAssert.AreEqual(expectedArray, originalArray);
		}

		/// <summary>
		/// Performs a test towards the logics of insertion sort algorithm when incoming array is empty.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void InsertionSortEmptyArray()
		{
			int[] originalArray = { };
			int[] expectedArray = { };

			SortApp.BL.Sortings.Sorter<int> insertionSorter = new SortApp.BL.Sortings.InsertionSort<int>();
			insertionSorter.Sort(originalArray);

			CollectionAssert.AreEqual(expectedArray, originalArray);
		}
	}
}
