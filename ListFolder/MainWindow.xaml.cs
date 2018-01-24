using ListFolder.ViewModels;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListFolder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow: MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private WindowModel _model = null;

        public WindowModel Model { get { if (_model == null) { _model = (WindowModel)this.DataContext; } return _model; } }

        private void ProjectNew_Click(object sender, RoutedEventArgs e)
        {
            var addPj = new AddPjWindow();
            transitionLayer.Content = addPj;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Model.ToString());
        }
    }
}
