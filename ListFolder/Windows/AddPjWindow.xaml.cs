using ListFolder.Data.Models;
using ListFolder.Data.Services;
using ListFolder.ViewModels;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListFolder
{
    /// <summary>
    /// AddPjWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddPjWindow
    {
        public AddPjWindow()
        {
            InitializeComponent();
        }

        private AddProjectModel _model = null;

        public AddProjectModel Model { get { if (_model == null) { _model = (AddProjectModel)this.DataContext; } return _model; } }

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            Model.ProjectService.Add(Model.Project); 
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var main = App.Current.MainWindow as MainWindow;
            main.transitionLayer.Content = main.Model.ListProjectWindow;
        }
    }
}
