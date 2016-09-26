using System;
using System.Windows.Input;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the view model object for arrays to save.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SaveWindowViewModel : ViewModelBase
	{
		/// <summary>
		/// Gets or sets command for button "Load".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Command for button "Load".
		/// </value>
		public ICommand ClickCommandSave
		{
			get;
		}

		/// <summary>
		/// Close action for current window.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public Action CloseAction
		{
			get;
			set;
		}

		/// <summary>
		/// Click action for button "Load".
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private void ClickMethodSave()
		{
			this.IsCanSave = true;

			this.CloseAction();
		}

		/// <summary>
		/// Gets or sets saving flag.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Flag which allows save data.
		/// </value>
		public bool IsCanSave
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets or sets array name.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The array name.
		/// </value>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SaveWindowViewModel"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public SaveWindowViewModel()
		{
			this.IsCanSave = false;

			this.ClickCommandSave = new Command(this.ClickMethodSave);
		}
	}
}
