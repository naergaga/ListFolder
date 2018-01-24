using ListFolder.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListFolder.ViewModels
{
    public class WindowModel
    {
        public WindowModel(ListProjectWindow listProjectWindow)
        {
            ListProjectWindow = listProjectWindow;
        }

        public ListProjectWindow ListProjectWindow { get; set; }

        public override string ToString()
        {
            return " ListProjectWindow: " + ListProjectWindow;
        }
    }
}
