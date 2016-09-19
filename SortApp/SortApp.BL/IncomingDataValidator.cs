using System;
using System.Text.RegularExpressions;

namespace SortApp.BL
{
	/// <summary>
	/// Represents the implementation of incoming data validator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class IncomingDataValidator
	{
		/// <summary>
		/// Checks incoming data.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="incomingData">
		/// Incoming data as string.
		/// </param>
		/// <returns>
		/// Valid status about incoming data.
		/// </returns>
		public bool IsValid(string incomingData)
		{
			if (incomingData == null)
				throw new ArgumentNullException();

			string pattern = @"^(\b((\d*)|( ))\b)*$";
			Regex regex = new Regex(pattern);

			return regex.IsMatch(incomingData);
		}
	}
}
