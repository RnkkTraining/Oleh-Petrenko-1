using System;
using System.Windows;
using SortApp.ViewModel;

namespace SortApp.Presentation.SaveArray
{
	/// <summary>
	/// Represents the implementation for saveArray service.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SaveArrayService : ISaveArrayService
	{
		/// <summary>
		/// Shows window for saving array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public void ShowSaveDialog(ViewModelBase dataContext)
		{
			Window saveWindow = new SaveDialogWindow
			{
				DataContext = dataContext
			};

			if (((SaveWindowViewModel)dataContext).CloseAction == null)
				((SaveWindowViewModel)dataContext).CloseAction = () => saveWindow.Close();

			saveWindow.ShowDialog();
		}
	}
}
