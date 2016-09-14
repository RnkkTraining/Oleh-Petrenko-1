using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortApp.BL;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the view model object for data.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class MainWindowViewModel : ViewModelBase
	{
		/// <summary>
		/// Gets or sets the Data.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The model for object Data.
		/// </value>
		public Data Data
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets all sorting iterations.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The dictionary with sorting iteratons.
		/// </value>
		public Dictionary<int, string> Iterations
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public MainWindowViewModel()
		{
			this.Data = new Data();
		}

		/// <summary>
		/// Gets or sets the original incoming array as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The incoming array as string.
		/// </value>
		public string OriginalData
		{
			get
			{
				return this.Data.OriginalData;
			}
			set
			{
				this.Data.OriginalData = value;
				OnPropertyChanged();
			}
		}
	}
}