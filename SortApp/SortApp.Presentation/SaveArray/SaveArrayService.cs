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
		/// <param name="dataContext">
		/// View model for current window.
		/// </param>
		public void ShowSaveDialog(SaveWindowViewModel dataContext)
		{
			Window saveWindow = new SaveDialogWindow
			{
				DataContext = dataContext
			};

			if (dataContext.CloseAction == null)
				dataContext.CloseAction = () => saveWindow.Close();

			saveWindow.ShowDialog();
		}
	}
}
