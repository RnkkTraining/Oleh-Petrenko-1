using System;
using System.Collections.Generic;
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
		/// The array with all elements from storage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private List<Data> arrays;

		/// <summary>
		/// The selected array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private Data selectedValue;

		/// <summary>
		/// Gets or sets array with array for sorting.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The array with all elements from storage.
		/// </value>
		public List<Data> Arrays
		{
			get
			{
				return this.arrays;
			}
			set
			{
				this.arrays = value;
				this.OnPropertyChanged();
			}
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
			get
			{
				return this.selectedValue;
			}
			set
			{
				this.selectedValue = value;
				this.OnPropertyChanged();
			}
		}
	}
}
