using System;
using System.Data;
using System.Data.SqlClient;

namespace SortApp.BL.DataAdapters
{
	/// <summary>
	/// Represents the implementation of DataAdapter creator.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class CreatorDataAdapterData : IDataAdapterCreator
	{
		/// <summary>
		/// Creates concrete implementation of dataAdapter for Data.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="connection">
		/// SqlConnection for queries.
		/// </param>
		/// <returns>
		/// Concrete implementation of dataAdapter for Data.
		/// </returns>
		public SqlDataAdapter CreateAdapter(SqlConnection connection)
		{
			SqlDataAdapter adapter = new SqlDataAdapter();

			//
			// SelectCommand.
			//
			SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Data WHERE Id = @Id", connection);
			adapter.SelectCommand = cmdSelect;

			SqlParameter parameter = adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int);
			parameter.SourceColumn = "Id";

			//
			// InsertCommand.
			//
			SqlCommand cmdInsert = new SqlCommand("INSERT INTO Data(OriginalData, SortedData, Name, KindOfSortingAlgorithm) " +
												"VALUES(@OriginalData, @SortedData, @Name, @KindOfSortingAlgorithm)", connection);
			adapter.InsertCommand = cmdInsert;

			parameter = adapter.InsertCommand.Parameters.Add("@OriginalData", SqlDbType.Text);
			parameter.SourceColumn = "OriginalData";

			parameter = adapter.InsertCommand.Parameters.Add("@SortedData", SqlDbType.Text);
			parameter.SourceColumn = "SortedData";

			parameter = adapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NChar, 255);
			parameter.SourceColumn = "Name";

			parameter = adapter.InsertCommand.Parameters.Add("@KindOfSortingAlgorithm", SqlDbType.Int);
			parameter.SourceColumn = "KindOfSortingAlgorithm";

			//
			// UpdateCommand.
			//
			SqlCommand cmdUpdt = new SqlCommand("UPDATE Data SET OriginalData = @OriginalData, SortedData = @SortedData, Name = @Name, " +
												"KindOfSortingAlgorithm = @KindOfSortingAlgorithm WHERE Id = @Id", connection);
			adapter.UpdateCommand = cmdUpdt;

			parameter = adapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int);
			parameter.SourceColumn = "Id";
			parameter.SourceVersion = DataRowVersion.Original;

			parameter = adapter.UpdateCommand.Parameters.Add("@OriginalData", SqlDbType.Text);
			parameter.SourceColumn = "OriginalData";

			parameter = adapter.UpdateCommand.Parameters.Add("@SortedData", SqlDbType.Text);
			parameter.SourceColumn = "SortedData";

			parameter = adapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NChar, 255);
			parameter.SourceColumn = "Name";

			parameter = adapter.UpdateCommand.Parameters.Add("@KindOfSortingAlgorithm", SqlDbType.Int);
			parameter.SourceColumn = "KindOfSortingAlgorithm";

			//
			// DeleteCommand.
			//
			SqlCommand cmdDlt = new SqlCommand("DELETE FROM Data WHERE Id = @Id", connection);
			adapter.DeleteCommand = cmdDlt;

			parameter = adapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int);
			parameter.SourceColumn = "Id";
			parameter.SourceVersion = DataRowVersion.Original;

			return adapter;
		}
	}
}
