namespace DashboardAkvelonProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        //
        /// <summary>
        /// Создание таблиц по моделям DashboardAkvelonProject.Models
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.Task",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(),
                    status = c.String(),
                    description = c.String(),
                    priroty = c.Int(nullable: false),
                    idProject = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Project", t => t.idProject, cascadeDelete: true)
                .Index(t => t.idProject);

            CreateTable(
                "dbo.Project",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(),
                    startProject = c.DateTime(),
                    completionProject = c.DateTime(),
                    statusProject = c.String(),
                    priroty = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "idProject", "dbo.Project");
            DropIndex("dbo.Task", new[] { "idProject" });
            DropTable("dbo.Task");
            DropTable("dbo.Project");
        }
    }
}
