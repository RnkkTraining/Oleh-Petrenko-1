﻿using System;
using System.Windows;
using SortApp.Presentation.LoadArray;
using SortApp.Presentation.SaveArray;
using SortApp.ViewModel;

namespace SortApp.Presentation
{
	/// <summary>
	/// Interaction logic for App.xaml.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public partial class App : Application
	{
		/// <summary>
		/// Starts application by opening its main window.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public App()
		{
			MainWindow mw = new MainWindow
			{
				DataContext = new MainWindowViewModel(
					new MessageBoxProvider(), new WindowCloseService(), new SaveArrayService(), new LoadArrayService())
			};

			mw.Show();
		}
	}
}
