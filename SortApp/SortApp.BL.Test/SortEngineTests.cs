using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.ArrayGenerators.Fakes;
using SortApp.BL.ItemsConvertors.Fakes;
using SortApp.BL.Sortings.Fakes;

namespace SortApp.BL.Test
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="SortEngine{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class SortEngineTests
	{
		/// <summary>
		/// Performs a logic for test towards the logics of sort engine.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void SortArrayTest()
		{
			string incoming = "9 8 7 6 5 4 3 2 1 0";
			string expected = "0 1 2 3 4 5 6 7 8 9 ";

			StubISortItemsCoverter<int> itemsConverter = new StubISortItemsCoverter<int>
			{
				//ConvertString = s => Convert.ToInt32(s)
			};

			StubIArrayGenerator<int> arrayGenerator = new StubIArrayGenerator<int>
			{
				GenerateFromStringStringISortItemsCoverterOfT0 = (s, converter) => new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			};

			StubSorter<int> sorter = new StubSorter<int>
			{
				SortT0Array = arr =>
				{
					arr = null;
				}
			};

			SortEngine<int> sortEngine = new SortEngine<int>();
			string result = sortEngine.Sort(incoming, sorter, arrayGenerator, itemsConverter);

			Assert.AreEqual(expected, result);
		}
	}
}
