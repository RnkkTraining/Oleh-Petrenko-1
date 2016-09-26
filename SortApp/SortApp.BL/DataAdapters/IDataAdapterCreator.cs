using System;
using System.Data.SqlClient;

namespace SortApp.BL.DataAdapters
{
	/// <summary>
	/// Represents the interface of DataAdapterCreator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface IDataAdapterCreator
	{
		/// <summary>
		/// Creates concrete implementation of dataAdapter.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="connection">
		/// SqlConnection for queries.
		/// </param>
		/// <returns>
		/// Concrete implementation of dataAdapter.
		/// </returns>
		SqlDataAdapter CreateAdapter(SqlConnection connection);
	}
}
