using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DasboardAkvelon.Models.Forms
{
    public class TaskForm
    {
        public string name { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int priroty { get; set; }
    }
}