using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.ViewModels
{
    public class NinjectServiceLocator
    {
        private readonly IKernel kernel;

        public NinjectServiceLocator()
        {
            kernel = new StandardKernel(new MvvmModule());
        }

        public AddProjectModel AddProjectModel
        {
            get
            {
                return kernel.Get<AddProjectModel>();
            }
        }

        public ListProjectModel ListProjectModel
        {
            get
            {
                return kernel.Get<ListProjectModel>();
            }
        }

        public WindowModel WindowModel
        {
            get
            {
                return kernel.Get<WindowModel>();
            }
        }
    }
}
