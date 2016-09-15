using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.Sortings;

namespace SortApp.BL.Test.Sorting
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="SortApp.BL.Sortings.SelectionSort{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class SelectionSortTests : BaseSortTests
	{
		/// <summary>
		/// Performs the entity which implementations selection sort algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		protected override Sorter<int> CreateSorter()
		{
			return new SelectionSort<int>();
		}
	}
}
