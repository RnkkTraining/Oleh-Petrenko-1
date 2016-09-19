using System;
using System.Windows.Input;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the implementation of ICommand interface.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class Command : ICommand
	{
		/// <summary>
		/// Contains reference to executing method.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public delegate void ActionDelegate();

		/// <summary>
		/// Checking for will able delegate be executed.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="parameter">
		/// Parameter for delegate.
		/// </param>
		public bool CanExecute(object parameter)
		{
			if (this.CanExecuteDelegate != null)
			{
				return this.CanExecuteDelegate(parameter);
			}

			return true;
		}

		/// <summary>
		/// Occurs when changes occur that affect whether or not the command should execute.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		/// <summary>
		/// Gets or sets predicate with condition for execution.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Predicate with condition for execution.
		/// </value>
		public Predicate<object> CanExecuteDelegate
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Command"/> class.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="action">
		/// Delegate for command.
		/// </param>
		public Command(ActionDelegate action)
		{
			this.ExecuteDelegate = action;
		}

		/// <summary>
		/// Execute delegate.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="parameter">
		/// Parameter for delegate.
		/// </param>
		public void Execute(object parameter)
		{
			this.ExecuteDelegate?.Invoke();
		}

		/// <summary>
		/// Gets or sets action for execution.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Action for execution.
		/// </value>
		public ActionDelegate ExecuteDelegate
		{
			get;
			set;
		}
	}
}
