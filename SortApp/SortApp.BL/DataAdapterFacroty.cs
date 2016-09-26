using System;
using SortApp.BL.DataAdapters;

namespace SortApp.BL
{
	/// <summary>
	/// Represents DataAdapter factory which provides the concrete dataAdapter realization.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class DataAdapterFacroty
	{
		/// <summary>
		/// Returns concrete CreatorDataAdapter implementation.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="dataAdapterKind">
		/// Kind of dataAdapter.
		/// </param>
		public IDataAdapterCreator CreateAdapter(DataAdapterKindEnum dataAdapterKind)
		{
			switch (dataAdapterKind)
			{
				case DataAdapterKindEnum.Data:
					return new CreatorDataAdapterData();
				case DataAdapterKindEnum.Iteration:
					return new CreatorDataAdapterIteration();
			}

			throw new NotSupportedException();
		}
	}
}
