using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortApp.BL.ArrayGenerators;
using SortApp.BL.ItemsConvertors;
using SortApp.BL.Sortings;

namespace SortApp.BL
{
	/// <summary>
	/// Represents the main logic towards sort engine.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SortEngine<T> where T : IComparable<T>
	{
        /// <summary>
        /// The array generator instance.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
	    private IArrayGenerator<T> arrayGenerator;

        /// <summary>
        /// The items converter instance.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
	    private ISortItemsCoverter<T> itemsConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortEngine{T}"/> class.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param name="arrayGenerator">
        /// Concrete implementations of array generator.
        /// </param>
        /// <param name="itemsConverter">
        /// Concrete implementations of items converter.
        /// </param>
        public SortEngine(IArrayGenerator<T> arrayGenerator, ISortItemsCoverter<T> itemsConverter)
        {
            this.arrayGenerator = arrayGenerator;
            this.itemsConverter = itemsConverter;
        }

		/// <summary>
		/// Takes incoming array as string and returns sorted array as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="incomingArr">
		/// Incoming array as string.
		/// </param>
		/// <param name="sorter">
		/// Concrete implementations of sorter.
		/// </param>
		public string Sort(string incomingArr, Sorter<T> sorter)
		{
			StringBuilder result = new StringBuilder(incomingArr.Length);

			T[] array = arrayGenerator.GenerateFromString(incomingArr);

			sorter.Sort(array);

			foreach (var item in array)
			{
				result.Append($"{item} ");
			}

			return result.ToString();
		}
	}
}
