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
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteDelegate != null)
            {
                return this.CanExecuteDelegate(parameter);
            }

            return true;
        }

        public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

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
        public Command(Action<object> action)
		{
			this.ExecuteDelegate = action;
		}

		public void Execute(object parameter)
		{
			this.ExecuteDelegate?.Invoke(parameter);
		}

		public Action<object> ExecuteDelegate
		{
			get;
			set;
		}
	}
}
