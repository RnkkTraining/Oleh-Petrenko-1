using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.ArrayGenerators.Fakes;
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
		/// Performs a logic for test towards the logics of sort engine when incoming array is filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void SortArrayFilledTest()
		{
			string incoming = "9 8 7 6 5 4 3 2 1 0";
			string expected = "0 1 2 3 4 5 6 7 8 9 ";

			StubIArrayGenerator<int> arrayGenerator = new StubIArrayGenerator<int>
			{
				GenerateFromStringString = (s) => new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			};

			SortEngine<int> sortEngine = new SortEngine<int>(arrayGenerator);
			string result = sortEngine.Sort(incoming, new StubSorter<int>());

			Assert.AreEqual(expected, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of sort engine when incoming array is null.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void SortArrayNullTest()
		{
			string incoming = null;
			string expected = string.Empty;
			
			SortEngine<int> sortEngine = new SortEngine<int>(new StubIArrayGenerator<int>());
			string result = sortEngine.Sort(incoming, new StubSorter<int>());

			Assert.AreEqual(expected, result);
		}
	}
}
