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
		public string ArrayState
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Iteration"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="indexOfFirstMovedElement">
		/// Index of first moved element.
		/// </param>
		/// <param name="indexOfSecondMovedElement">
		/// Index of second moved element.
		/// </param>
		/// <param name="number">
		/// Iteration number.
		/// </param>
		public Iteration(int indexOfFirstMovedElement, int indexOfSecondMovedElement, int number)
		{
			this.IndexOfFirstMovedElement = indexOfFirstMovedElement;
			this.IndexOfSecondMovedElement = indexOfSecondMovedElement;
			this.Number = number;
		}

		/// <summary>
		/// Gets or sets index of first element which was moved.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Index of first element.
		/// </value>
		public int IndexOfFirstMovedElement
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
		public int IndexOfSecondMovedElement
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
