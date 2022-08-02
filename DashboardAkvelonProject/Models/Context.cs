using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DashboardAkvelonProject.Models
{
    public class Context:DbContext
    {
        public Context():
            base("DefaultConnection")
        { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}