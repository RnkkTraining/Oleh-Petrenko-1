using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp.BL.Sortings
{
	/// <summary>
	/// Base class for sorting algorithms.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public abstract class Sorter<T> where T : IComparable<T>
	{
		/// <summary>
		/// Adds current iteration to iterations.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// The current state of the array.
		/// </param>
		/// <param name="firstIndex">
		/// Index of first element which was moved.
		/// </param>
		/// <param name="secondIndex">
		/// Index of second element which was moved.
		/// </param>
		protected void AddIteration(T[] arr, int firstIndex, int secondIndex)
		{
			Iteration curretnIteration = new Iteration(firstIndex, secondIndex, this.Iterations.Count + 1);

			StringBuilder result = new StringBuilder(arr.Length);

			foreach (T item in arr)
			{
				result.Append($"{item} ");
			}

			curretnIteration.ArrayState = result.ToString();

			this.Iterations.Add(curretnIteration);
		}

		/// <summary>
		/// Gets or sets all sorting iterations.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Sorting iterations.
		/// </param>
		public List<Iteration> Iterations
		{
			get;
			private set;
		}

		/// <summary>
		/// Implementing sorting algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param>
		/// Incoming array for sorting.
		/// </param>
		public abstract void Sort(T[] arr);

		/// <summary>
		/// Initializes a new instance of the <see cref="Sorter{T}"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		protected Sorter()
		{
			this.Iterations = new List<Iteration>();
		}

		/// <summary>
		/// Swap two elements.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// Array for swap elements.
		/// </param>
		/// <param name="firstIndex">
		/// Index of first element for swap.
		/// </param>
		/// <param name="secondIndex">
		/// Index of second element for swap.
		/// </param>
		protected void Swap(T[] arr, int firstIndex, int secondIndex)
		{
			T tmp = arr[firstIndex];
			arr[firstIndex] = arr[secondIndex];
			arr[secondIndex] = tmp;
		}
	}
}