using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DasboardAkvelon.Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():
            base("name=Context")
        { }
        public DbSet<Project> Projects { get; set; } 
    }
}