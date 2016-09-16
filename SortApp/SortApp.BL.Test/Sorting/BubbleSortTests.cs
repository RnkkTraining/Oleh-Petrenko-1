using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.Sortings;

namespace SortApp.BL.Test.Sorting
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="Sortings.BubbleSort{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class BubbleSortTests : BaseSortTests
	{
		/// <summary>
		/// Performs the entity which implementations bubble sort algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		protected override Sorter<int> CreateSorter()
		{
			return new BubbleSort<int>();
		}
	}
}
