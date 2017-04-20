using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MyProject1.ViewModels;
using MyProject1.Views;

namespace MyProject1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // Create view and bind to new viewmodel
            MainWindow v = new Views.MainWindow();
            v.DataContext = new MainViewModel();
            v.Show();
        }
    }
}
