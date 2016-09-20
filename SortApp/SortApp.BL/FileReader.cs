using System;
using System.IO;

namespace SortApp.BL
{
	/// <summary>
	/// Represents the logic towards file reader.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public static class FileReader
	{
		/// <summary>
		/// Read file to string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="filePath">
		/// File path.
		/// </param>
		/// <returns>
		/// Readed file as string.
		/// </returns>
		public static string ReadToString(string filePath)
		{
			if (filePath == null)
				throw new ArgumentNullException();

			string result = string.Empty;

			using (StreamReader sr = new StreamReader(filePath))
			{
				result = sr.ReadToEnd();
			}

			return result;
		}
	}
}
