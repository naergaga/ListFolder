using ListFolder.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.Data
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext():base("conn1")
        {

        }

        public DbSet<Project> Project { get; set; }
    }
}
