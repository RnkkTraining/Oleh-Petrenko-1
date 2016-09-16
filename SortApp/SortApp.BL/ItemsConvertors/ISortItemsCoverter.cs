using System;

namespace SortApp.BL.ItemsConvertors
{
	/// <summary>
	/// Represents the interface of items convertor.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface ISortItemsCoverter<out T>
	{
		/// <summary>
		/// Convert incoming value as string to specific type.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="value">
		/// Incoming value as string.
		/// </param>
		T Convert(string value);
	}
}
