using ListFolder.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.Data.Services
{
    public class ProjectService
    {
        internal ProjectDbContext _context;
        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }

        public List<Project> GetList()
        {
            return _context.Project.ToList();
        }

        public void Add(Project project)
        {
            project.AddTime = DateTime.Now;
            _context.Project.Add(project);
            _context.SaveChanges();
        }

        public void Edit(Project project)
        {
            _context.Entry(project).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void Remove(Project project)
        {
            _context.Entry(project).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
