using ListFolder.Data.Models;
using ListFolder.Data.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.ViewModels
{
    public class ListProjectModel
    {
        public ListProjectModel(ProjectService service)
        {
            ProjectService = service;
            List = new ObservableCollection<Project>(service.GetList());
            List.CollectionChanged += List_CollectionChanged;
        }

        private void List_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems.Count==1)
            {
                ProjectService.Remove(e.OldItems[0] as Project);
            }
        }

        public ProjectService ProjectService { get; set; }
        public ObservableCollection<Project> List { get; set; }
    }
}
