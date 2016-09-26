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
		public void ShowLoadArrayWindow(ViewModelBase dataContext)
		{
			LoadArrayWindow loadArrayWindow = new LoadArrayWindow()
			{
				DataContext = dataContext
			};

			if (((LoadWindowViewModel)dataContext).CloseAction == null)
				((LoadWindowViewModel)dataContext).CloseAction = () => loadArrayWindow.Close();

			loadArrayWindow.ShowDialog();
		}
	}
}
