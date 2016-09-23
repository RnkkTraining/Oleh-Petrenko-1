using System;
using System.Collections.Generic;
using System.Windows.Input;
using SortApp.BL;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the view model object for arrays in storage.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class LoadWindowViewModel : ViewModelBase
	{
		/// <summary>
		/// Gets or sets array with array for sorting.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The array with all elements from storage.
		/// </value>
		public List<Data> Arrays
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets selected data for MainWindowViewModel.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The selected data for MainWindowViewModel.
		/// </value>
		public Data SelectedData
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets or sets selected array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The selected array.
		/// </value>
		public Data SelectedValue
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets command for button "Load".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Command for button "Load".
		/// </value>
		public ICommand ClickCommandLoad
		{
			get;
			set;
		}

		/// <summary>
		/// Click action for button "Load".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private void ClickMethodLoad()
		{
			this.SelectedData = this.SelectedValue;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LoadWindowViewModel"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public LoadWindowViewModel()
		{
			this.ClickCommandLoad = new Command(this.ClickMethodLoad);
		}
	}
}
