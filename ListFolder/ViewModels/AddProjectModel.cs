using ListFolder.Data.Models;
using ListFolder.Data.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.ViewModels
{
    public class AddProjectModel
    {
        public AddProjectModel(ProjectService projectService)
        {
            Project = new Project();
            ProjectService = projectService;
        }

        public Project Project { get; set; }
        public ProjectService ProjectService { get; set; }
    }
}
