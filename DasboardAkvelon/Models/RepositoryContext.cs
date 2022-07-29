using DasboardAkvelon.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DasboardAkvelon.Models
{
    public class RepositoryContext
    {
        public TaskContext dbTask { get; set; }
        public ProjectContext dbProject { get; set; }
        public RepositoryContext() 
        {
            dbProject = new ProjectContext();
            dbTask = new TaskContext();
        }
        
    }
}