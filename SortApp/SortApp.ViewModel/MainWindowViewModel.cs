using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using SortApp.BL;
using SortApp.BL.ArrayGenerators;
using SortApp.BL.ItemsConvertors;
using SortApp.BL.Sortings;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the view model object for data.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class MainWindowViewModel : ViewModelBase
	{
		/// <summary>
		/// Contains SortEngine object.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private readonly SortEngine<int> sortEngine;

		/// <summary>
		/// Contains concrete implementation of sorter factory.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private readonly SorterFactory<int> sorterFactory;

		/// <summary>
		/// Contains concrete implementation of messagebox provider.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private readonly IMessageBoxProvider messageBoxProvider;

		/// <summary>
		/// Contains concrete implementation of validator for incoming string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private readonly IncomingDataValidator validator;

		/// <summary>
		/// Contains concrete implementation of windowclose service.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private readonly IWindowCloseService windowCloseService;

		/// <summary>
		/// Gets or sets command for button "Close".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Command for button "Close".
		/// </value>
		public ICommand ClickCommandClose
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets command for button "Help".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Command for button "Help".
		/// </value>
		public ICommand ClickCommandHelp
		{
			get;
			set;
		}

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
		/// Click action for button "Close".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private void ClickMethodClose()
		{
			if (this.messageBoxProvider.ShowMessage("Do you want to close application?", "Close", MessageBoxButtons.OKCancel))
				this.windowCloseService.Close();
		}

		/// <summary>
		/// Click action for button "Help".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private void ClickMethodHelp()
		{
			string helpFile = FileReader.ReadToString(@"../../../files/help.txt");

			this.messageBoxProvider.ShowMessage(helpFile, "Help", MessageBoxButtons.OK);
		}

		/// <summary>
		/// Click action for button "Sort".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private void ClickMethodSort()
		{
			if (!this.validator.IsValid(this.OriginalData))
			{
				this.messageBoxProvider.ShowMessage("Incoming array is invalid", "Exception", MessageBoxButtons.OK);
				return;
			}

			Sorter<int> sorter = sorterFactory.CreateSorter(this.SelectedAlgorithm);

			this.ResultSorting = sortEngine.Sort(this.OriginalData, sorter);
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
		public MainWindowViewModel(IMessageBoxProvider messageBoxProvider, IWindowCloseService windowCloseService)
		{
			this.windowCloseService = windowCloseService;
			this.messageBoxProvider = messageBoxProvider;

			this.Data = new Data();

			this.validator = new IncomingDataValidator();
			this.SortingAlgorithmSelection = SortingAlgorithmNameAccordanceKindCreator.CreateDictionary();
			this.sortEngine = new SortEngine<int>(new ArrayGenerator<int>(new ConverterStringToInt()));
			this.sorterFactory = new SorterFactory<int>();

			this.ClickCommandClose = new Command(this.ClickMethodClose);
			this.ClickCommandHelp = new Command(this.ClickMethodHelp);
			this.ClickCommandSort = new Command(this.ClickMethodSort);
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
			private set
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