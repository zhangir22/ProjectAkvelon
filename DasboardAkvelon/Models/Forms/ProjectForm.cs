using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DasboardAkvelon.Models.Forms
{
    public class ProjectForm
    {
        public string Name { get; set; }
        public DateTime StartProject { get; set; }
        public DateTime CompletionProjct { get; set; }
        public string StatusProject { get; set; }
        public int Priroty { get; set; }

    }
}