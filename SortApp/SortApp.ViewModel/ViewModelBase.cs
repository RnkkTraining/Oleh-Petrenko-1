using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SortApp.ViewModel
{
    /// <summary>
    /// Represents the view model base as parent for all view model.
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Update property.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <value>
        /// The property name which will be updated.
        /// </value>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Represents the view model base as parent for all view model.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
