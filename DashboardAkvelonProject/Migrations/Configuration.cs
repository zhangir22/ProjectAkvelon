namespace DashboardAkvelonProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DashboardAkvelonProject.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<DashboardAkvelonProject.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DashboardAkvelonProject.Models.Context context)
        {
            
        }
    }
}
