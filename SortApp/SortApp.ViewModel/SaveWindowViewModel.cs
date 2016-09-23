using System;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the view model object for arrays to save.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class SaveWindowViewModel : ViewModelBase
	{
		/// <summary>
		/// The array name.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		private string name;

		/// <summary>
		/// Gets or sets array name.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The array name.
		/// </value>
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.OnPropertyChanged();
			}
		}
	}
}
