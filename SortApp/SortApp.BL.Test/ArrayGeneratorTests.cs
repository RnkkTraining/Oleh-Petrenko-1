using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.ArrayGenerators;
using SortApp.BL.ItemsConvertors.Fakes;

namespace SortApp.BL.Test
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="ArrayGenerator{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class ArrayGeneratorTests
	{
		/// <summary>
		/// Performs a logic for test towards the logics of array generator when incoming array is empty.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ArrayGeneratorEmptyArrayTest()
		{
			string incoming = string.Empty;
			int[] expected = { };

			StubISortItemsCoverter<int> itemsCoverter = new StubISortItemsCoverter<int>
			{
				ConvertString = s => Convert.ToInt32(s)
			};

			IArrayGenerator<int> arrayGenerator = new ArrayGenerator<int>(itemsCoverter);

			int[] result = arrayGenerator.GenerateFromString(incoming);

			CollectionAssert.AreEqual(expected, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of array generator when incoming array is filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ArrayGeneratorFilledArrayTest()
		{
			string incoming = "0 1 2 3 4 5 6 7 8 9";
			int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			StubISortItemsCoverter<int> itemsCoverter = new StubISortItemsCoverter<int>
			{
				ConvertString = s => Convert.ToInt32(s)
			};

			IArrayGenerator<int> arrayGenerator = new ArrayGenerator<int>(itemsCoverter);

			int[] result = arrayGenerator.GenerateFromString(incoming);

			CollectionAssert.AreEqual(expected, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of array generator when incoming array is null.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ArrayGeneratorNullTest()
		{
			string incoming = null;

			StubISortItemsCoverter<int> itemsCoverter = new StubISortItemsCoverter<int>
			{
				ConvertString = s => Convert.ToInt32(s)
			};

			IArrayGenerator<int> arrayGenerator = new ArrayGenerator<int>(itemsCoverter);

			int[] result = arrayGenerator.GenerateFromString(incoming);
		}
	}
}
