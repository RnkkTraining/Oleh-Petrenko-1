using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SortApp.ViewModel
{
    /// <summary>
    /// Represents the view model base as parent for all view model.
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Update property.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param>
        /// The property name which will be updated.
        /// </param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Call when property was changed.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
