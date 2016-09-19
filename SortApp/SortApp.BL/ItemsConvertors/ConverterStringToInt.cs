using System;

namespace SortApp.BL.ItemsConvertors
{
	/// <summary>
	/// Represents the implementation for items converter from string to int.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class ConverterStringToInt : ISortItemsCoverter<int>
	{
		/// <summary>
		/// Convert incoming value as string to int.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="value">
		/// Incoming value as string.
		/// </param>
		public int Convert(string value)
		{
			if (value == null)
				throw new ArgumentNullException();

			return value == string.Empty ? 0 : System.Convert.ToInt32(value);
		}
	}
}
