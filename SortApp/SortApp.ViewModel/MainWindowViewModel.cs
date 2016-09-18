using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        /// Gets or sets command for button "Sort".
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <value>
        /// Command for button "Sort".
        /// </value>
	    public ICommand ClickCommandSort
	    {
	        get;
            set;
	    }

        /// <summary>
        /// Click action for button "Sort".
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        private void ClickMethodSort()
        {
            this.ResultSorting = SelectedAlgorithm.ToString();
        }

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
            this.ClickCommandSort = new Command(arg => ClickMethodSort());
		    this.SortingAlgorithmSelection = SortingAlgorithmNameAccordanceKindCreator.CreateDictionary();
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
				this.OnPropertyChanged();
			}
		}

        /// <summary>
		/// Gets or sets the sorted array as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The sorted array as string.
		/// </value>
	    public string ResultSorting
	    {
            get
            {
                return this.Data.SortedData;
            }
            set
            {
                this.Data.SortedData = value;
                this.OnPropertyChanged();
            }
	    }

		/// <summary>
		/// Gets or sets the selected algorithm.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The selected algorithm as element of enum.
		/// </value>
		public SortingAlgorithmKind SelectedAlgorithm
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets key-value pairs with name of algorithm and element of enum.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The key-value pairs with name of algorithm and element of enum.
		/// </value>
		public Dictionary<string, SortingAlgorithmKind> SortingAlgorithmSelection
		{
			get;
			private set;
		}
	}
}