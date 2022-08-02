using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardAkvelonProject.Models
{
    [Table("Project")]
    public class Project
    {
        public int id { get; set; }

        [Display(Name = "Name Project")]
        public string name { get; set; }

        [Display(Name = "Start Project")]
        [DataType(DataType.Date)]
        public DateTime startProject { get; set; }

        [Display(Name = "Competion Project")]
        [DataType(DataType.Date)]
        public DateTime completionProject { get; set; }

        [Display(Name = "Status Project")]
        public string statusProject { get; set; }

        [Display(Name = "Priroty")]
        public int priroty { get; set; }

    }
}