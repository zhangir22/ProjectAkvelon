using DashboardAkvelonProject.Abstract;
using DashboardAkvelonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DashboardAkvelonProject.Models.Repository
{
    public class ProjectRepos:IRepos
    {
        /// <summary>
        /// Реалазиация Интерфейса DashboardAkvelon.Abstract.IRepos
        /// </summary>
        
        public Context db { get; set; }
        public ProjectRepos()
        {
            db = new Context();
        }
        public List<Project> GetAllProject()
        {
            return db.Projects.ToList();
        }
        public void GetTasksByElementId(List<Task> tasks, int id)
        {
            foreach (var item in db.Tasks)
            {
                if (item.idProject == id)
                {
                    tasks.Add(item);
                }
            }
        }
        public List<Task> Tasks(int id)
        {
            List<Task> tasks = new List<Task>();
            GetTasksByElementId(tasks, id);
            return tasks;
        }
        public Task DetailsTask(int id, int idProjects)
        {
            Task task = db.Tasks.FirstOrDefault(u => u.id == id && u.idProject == idProjects);
            return task;
        }
        public Project DetailsProject(int id)
        {
            Project project = db.Projects.Find(id);
            return project;
        }
        public Task Create(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
            return task;
        }
        public Project Create(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }
        public void DeleteTask(int id)
        {
            Task task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
        }
        public void DeleteProject(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
        }
        public Task EditTask(Task task)
        {
            Task item = db.Tasks.Find(task.id);
            item.name = task.name;
            item.description = task.description;
            item.priroty = task.priroty;
            item.status = task.status;
            item.idProject = task.idProject;
            db.SaveChanges();
            return item;
        }
        public Project EditProject(Project project)
        {
            Project item = db.Projects.Find(project.id);
            item.name = project.name;
            item.startProject = project.startProject;
            item.completionProject = project.completionProject;
            item.statusProject = project.statusProject;
            db.SaveChanges();
            return item;
        }
    }
}