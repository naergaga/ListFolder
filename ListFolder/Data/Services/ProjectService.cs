using ListFolder.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.Data.Services
{
    public class ProjectService
    {
        private ProjectDbContext _context;
        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            project.AddTime = DateTime.Now;
            _context.Project.Add(project);
            _context.SaveChanges();
        }
    }
}
