using System;
using SortApp.ViewModel;

namespace SortApp.Presentation.LoadArray
{
	/// <summary>
	/// Represents the implementation for loadArray service.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class LoadArrayService : ILoadArrayService
	{
		/// <summary>
		/// Shows window for loading array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="dataContext">
		/// View model for current window.
		/// </param>
		public void ShowLoadArrayWindow(LoadWindowViewModel dataContext)
		{
			LoadArrayWindow loadArrayWindow = new LoadArrayWindow
			{
				DataContext = dataContext
			};

			if (dataContext.CloseAction == null)
				dataContext.CloseAction = () => loadArrayWindow.Close();

			loadArrayWindow.ShowDialog();
		}
	}
}
