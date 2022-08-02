using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardAkvelonProject.Models
{
    [Table("Task")]
    public class Task
    {
        public int id { get; set; }
        [Display(Name = "Task Name")]

        public string name { get; set; }
        [Display(Name = "Task Status")]

        public string status { get; set; }
        [Display(Name = "Task Description")]

        public string description { get; set; }
        [Display(Name = "Task Priroty")]
        public int priroty { get; set; }

        public int idProject { get; set; }
    }
}