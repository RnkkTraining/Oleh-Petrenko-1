using System;

namespace SortApp.BL
{
	/// <summary>
	/// Represents the iteration model.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class Iteration
	{
		/// <summary>
		/// Gets or sets array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The current state of the array.
		/// </value>
		public string Array
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets index of first element which was moved.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Index of first element.
		/// </value>
		public int IndexOfFirstElement
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets index of second element which was moved.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Index of second element.
		/// </value>
		public int IndexOfSecondElement
		{
			get;
			set;
		}

		/// <summary>
		/// Get or sets iteration number.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Iteration number.
		/// </value>
		public int Number
		{
			get;
			set;
		}
	}
}
