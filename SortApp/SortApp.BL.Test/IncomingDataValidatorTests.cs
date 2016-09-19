using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortApp.BL.Test
{
	/// <summary>
	/// Represents the tests executed towards the <see cref="IncomingDataValidator"/> sorting class.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	[TestClass]
	public sealed class IncomingDataValidatorTests
	{
		/// <summary>
		/// Performs a logic for test towards the logics of validator when incoming array is correct filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ValidatorArrayCorrectFilledTest()
		{
			string incoming = "0 1 2 3 4 5 6 7 8 9";

			IncomingDataValidator validator = new IncomingDataValidator();
			bool result = validator.IsValid(incoming);

			Assert.AreEqual(true, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of validator when incoming array is uncorrect filled.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		public void ValidatorArrayUncorrectFilledTest()
		{
			string incoming = "0 1 2 3 aaa 6 7 8 9";

			IncomingDataValidator validator = new IncomingDataValidator();
			bool result = validator.IsValid(incoming);

			Assert.AreEqual(false, result);
		}

		/// <summary>
		/// Performs a logic for test towards the logics of validator when incoming array is null.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ValidatorArrayNullTest()
		{
			string incoming = null;

			IncomingDataValidator validator = new IncomingDataValidator();
			bool result = validator.IsValid(incoming);
		}
	}
}
