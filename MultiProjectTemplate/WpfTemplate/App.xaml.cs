using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows;
using $safeprojectname$.ViewModels;
using $safeprojectname$.Views;

namespace $safeprojectname$
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
