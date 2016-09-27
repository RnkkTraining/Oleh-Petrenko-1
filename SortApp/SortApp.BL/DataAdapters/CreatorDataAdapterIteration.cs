using System;
using System.Data;
using System.Data.SqlClient;

namespace SortApp.BL.DataAdapters
{
	/// <summary>
	/// Represents the implementation of DataAdapter creator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class CreatorDataAdapterIteration : IDataAdapterCreator
	{
		/// <summary>
		/// Creates concrete implementation of dataAdapter for Iterarion.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="connection">
		/// SqlConnection for queries.
		/// </param>
		/// <returns>
		/// Concrete implementation of dataAdapter for Iterarion.
		/// </returns>
		public SqlDataAdapter CreateAdapter(SqlConnection connection)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();

			//
			// SelectCommand.
			//
			SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Iteration WHERE DataId = @DataId", connection);
			adapter.SelectCommand = cmdSelect;

			SqlParameter parameter = adapter.SelectCommand.Parameters.Add("@DataId", SqlDbType.Int);
			parameter.SourceColumn = "DataId";

			//
			// InsertCommand.
			//
			SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO Iteration(ArrayState, IndexOfFirstMovedElement, IndexOfSecondMovedElement, Number, DataId) 
													VALUES(@ArrayState, @IndexOfFirstMovedElement, @IndexOfSecondMovedElement, @Number, @DataId)", connection);
			adapter.InsertCommand = cmdInsert;

			parameter = adapter.InsertCommand.Parameters.Add("@ArrayState", SqlDbType.Text);
			parameter.SourceColumn = "ArrayState";

			parameter = adapter.InsertCommand.Parameters.Add("@IndexOfFirstMovedElement", SqlDbType.Int);
			parameter.SourceColumn = "IndexOfFirstMovedElement";

			parameter = adapter.InsertCommand.Parameters.Add("@IndexOfSecondMovedElement", SqlDbType.Int);
			parameter.SourceColumn = "IndexOfSecondMovedElement";

			parameter = adapter.InsertCommand.Parameters.Add("@Number", SqlDbType.Int);
			parameter.SourceColumn = "Number";

			parameter = adapter.InsertCommand.Parameters.Add("@DataId", SqlDbType.Int);
			parameter.SourceColumn = "DataId";

			return adapter;
		}
	}
}
