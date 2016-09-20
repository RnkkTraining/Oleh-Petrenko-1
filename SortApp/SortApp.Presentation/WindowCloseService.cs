using System;
using System.Windows;
using SortApp.ViewModel;

namespace SortApp.Presentation
{
	/// <summary>
	/// Represents the implementation for windowclose service.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class WindowCloseService : IWindowCloseService
	{
		/// <summary>
		/// Closes window.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public void Close()
		{
			Application.Current.Shutdown();
		}
	}
}
