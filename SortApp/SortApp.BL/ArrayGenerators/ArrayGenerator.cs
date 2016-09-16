using System;
using System.Linq;
using SortApp.BL.ItemsConvertors;

namespace SortApp.BL.ArrayGenerators
{
	/// <summary>
	/// Represents the implementetion of array generator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class ArrayGenerator<T> : IArrayGenerator<T>
	{
		/// <summary>
		/// Generate array from incoming string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// Incoming array.
		/// </param>
		/// <param name="itemConverter">
		/// Concrete implementation item converter.
		/// </param>
		public T[] GenerateFromString(string arr, ISortItemsCoverter<T> itemConverter)
		{
			if(arr == null)
				throw new NullReferenceException();

			if (arr == string.Empty)
				return new T[] { };

			return arr.Split(' ').Select(itemConverter.Convert).ToArray();
		}
	}
}
