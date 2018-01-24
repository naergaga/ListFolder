using ListFolder.Data.Models;
using ListFolder.ViewModels;
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
using System.Windows.Shapes;

namespace ListFolder.Windows
{
    /// <summary>
    /// ListProject.xaml 的交互逻辑
    /// </summary>
    public partial class ListProjectWindow
    {
        public ListProjectWindow()
        {
            InitializeComponent();
        }

        private ListProjectModel _model = null;

        public ListProjectModel Model { get { if (_model == null) { _model = (ListProjectModel)this.DataContext; } return _model; } }

        private void DataGrid_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {
            var p = e.NewItem as Project; if (p != null) p.AddTime = DateTime.Now;
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                Dispatcher.BeginInvoke(new Action(() => DataGrid_RowEditEnded(e)), System.Windows.Threading.DispatcherPriority.Background);
            }
        }

        private void DataGrid_RowEditEnded(DataGridRowEditEndingEventArgs e)
        {
            var project = e.Row.DataContext as Project;
            bool isInsert = false;
            if (project == null) return;
            if (project.Id == 0)
            {
                isInsert = true;
            }

            if (isInsert)
            {
                Model.ProjectService.Add(project);
            }else
            {
                Model.ProjectService.Edit(project);
            }
        }
    }
}
