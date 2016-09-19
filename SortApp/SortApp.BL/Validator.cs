using System;
using System.Text.RegularExpressions;

namespace SortApp.BL
{
	public sealed class Validator
	{
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
