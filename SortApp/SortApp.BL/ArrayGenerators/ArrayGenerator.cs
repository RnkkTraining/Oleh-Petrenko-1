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
		/// Initializes a new instance of the <see cref="ArrayGenerator{T}"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="itemsConverter">
		/// Concrete implementations of items converter.
		/// </param>
		public ArrayGenerator(ISortItemsCoverter<T> itemsConverter)
		{
			this.itemsConverter = itemsConverter;
		}

		/// <summary>
		/// Generate array from incoming string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="arr">
		/// Incoming array.
		/// </param>
		public T[] GenerateFromString(string arr)
		{
			if (arr == null)
				throw new NullReferenceException();

			if (arr == string.Empty)
				return new T[] { };

			return arr.Split(' ').Select(this.itemsConverter.Convert).ToArray();
		}

		/// <summary>
		/// The items converter instance.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private ISortItemsCoverter<T> itemsConverter;
	}
}
