using ListFolder.Data;
using ListFolder.Data.Services;
using Ninject;
using Ninject.Modules;

namespace ListFolder.ViewModels
{
    public class MvvmModule:NinjectModule
    {
        public MvvmModule()
        {
        }

        public override void Load()
        {
            Kernel.Bind<ProjectDbContext>().To<ProjectDbContext>();
            Kernel.Bind<ProjectService>().To<ProjectService>();
        }
    }
}