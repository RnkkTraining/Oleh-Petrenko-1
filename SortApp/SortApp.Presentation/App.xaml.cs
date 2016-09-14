using System;
using System.Windows;
using SortApp.ViewModel;

namespace SortApp.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Sets the data context for MainWindow.
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        public App()
        {
            var mw = new SortApp.Presentation.MainWindow
            {
                DataContext = new MainWindowViewModel()
            };

            mw.Show();
        }
    }
}
