using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortApp.BL.ItemsConvertors;

namespace SortApp.BL.Test
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="ConverterStringToInt{T}"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class ConverterStringToIntTests
	{
		/// <summary>
		/// Performs a logic for test towards the logics of items converter when incoming value is empty string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ConvertEmptyStringToIntTest()
		{
			string incoming = string.Empty;
			int expected = 0;

			ISortItemsCoverter<int> itemsCoverter = new ConverterStringToInt<int>();
			int result = itemsCoverter.Convert(incoming);

			Assert.AreEqual(expected, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of items converter when incoming value is null.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ConvertNullToIntTest()
		{
			string incoming = null;
			int expected = 0;

			ISortItemsCoverter<int> itemsCoverter = new ConverterStringToInt<int>();
			int result = itemsCoverter.Convert(incoming);

			Assert.AreEqual(expected, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of items converter when incoming value is number as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ConvertNumberAsStringToIntTest()
		{
			string incoming = "35";
			int expected = 35;

			ISortItemsCoverter<int> itemsCoverter = new ConverterStringToInt<int>();
			int result = itemsCoverter.Convert(incoming);

			Assert.AreEqual(expected, result);
		}
	}
}
