using System;
using System.Windows.Input;

namespace SortApp.ViewModel
{
	class Command : ICommand
	{
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

		public bool CanExecute(object parameter)
		{
			if (CanExecuteDelegate != null)
			{
				return CanExecuteDelegate(parameter);
			}

			return true;
		}

		public Command(Action<object> action)
		{
			ExecuteDelegate = action;
		}

		public void Execute(object parameter)
		{
			ExecuteDelegate?.Invoke(parameter);
		}

		public Action<object> ExecuteDelegate
		{
			get;
			set;
		}
	}
}
