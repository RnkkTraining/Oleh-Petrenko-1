using System;
using System.Windows.Forms;
using SortApp.ViewModel;

namespace SortApp.Presentation
{
	/// <summary>
	/// Represents the implementation for messagebox provider.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class MessageBoxProvider : IMessageBoxProvider
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
		public bool ShowMessage(string text, string caption, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, caption, buttons) == DialogResult.OK;
		}
	}
}
