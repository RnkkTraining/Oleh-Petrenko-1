using System;
using System.Windows.Forms;

namespace SortApp.ViewModel
{
	/// <summary>
	/// Represents the interface for messagebox provider.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface IMessageBoxProvider
	{
		/// <summary>
		/// Returns result of user action.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="text">
		/// Text inside messagebox.
		/// </param>
		/// <param name="caption">
		/// Massagebox caption.
		/// </param>
		/// <param name="buttons">
		/// Messagebox buttons.
		/// </param>
		/// <returns>
		/// Result of user action.
		/// </returns>
		bool ShowMessage(string text, string caption, MessageBoxButtons buttons);
	}
}
