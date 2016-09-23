﻿using System;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the interface for save array service.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface ISaveArrayService
	{
		/// <summary>
		/// Window for saving array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param></param>
		/// <param name="dataContext">
		/// DataContext for window.
		/// </param>
		void ShowSaveDialog(ViewModelBase dataContext);
	}
}
