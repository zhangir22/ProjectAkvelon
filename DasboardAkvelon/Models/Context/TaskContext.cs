using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DasboardAkvelon.Models.Context
{
    public class TaskContext:DbContext
    {
        public TaskContext():
            base("name=Context")
        { }
        public DbSet<Task> Tasks { get; set; }
    }
}