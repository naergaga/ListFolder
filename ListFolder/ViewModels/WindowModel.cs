using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListFolder.ViewModels
{
    public class WindowModel:BaseModel
    {
        private Visibility createProjectVisibility = Visibility.Collapsed;

        public Visibility ShowCreate
        {
            get { return createProjectVisibility; }
            set
            {
                createProjectVisibility = value;
                RaisePropertyChanged("ShowCreate");
            }
        }
    }
}
