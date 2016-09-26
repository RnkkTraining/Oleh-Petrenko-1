using System;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the interface for load array service.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface ILoadArrayService
	{
		/// <summary>
		/// Window for loading array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="dataContext">
		/// DataContext for window.
		/// </param>
		void ShowLoadArrayWindow(LoadWindowViewModel dataContext);
	}
}
