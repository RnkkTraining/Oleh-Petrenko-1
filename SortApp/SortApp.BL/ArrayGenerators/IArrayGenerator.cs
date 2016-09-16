using System;
using SortApp.BL.ItemsConvertors;

namespace SortApp.BL.ArrayGenerators
{
	/// <summary>
	/// Represents the interface of array generator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface IArrayGenerator<T>
	{
		/// <summary>
		/// Generate array from incoming string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// Incoming array.
		/// </param>
		/// <param name="itemConverter">
		/// Concrete implementation items converter.
		/// </param>
		T[] GenerateFromString(string arr, ISortItemsCoverter<T> itemConverter);
	}
}
