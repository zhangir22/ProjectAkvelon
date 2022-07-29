using DasboardAkvelon.Abstract;
using DasboardAkvelon.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DasboardAkvelon.Models
{
    public class ProjectRepos : IRepos
    {
        public ProjectContext dbProject { get; set; }
        public TaskContext dbTask { get; set; }
        public ProjectRepos() 
        {
            dbProject = new ProjectContext();
            dbTask = new TaskContext();
        }
        public List<Project> GetAllProject() 
        {
            return dbProject.Projects.ToList();
        }
        public void GetTasksByElementId(List<Task>tasks,int id)
        {
            foreach (var item in dbTask.Tasks)
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
        public Task DetailsTask(int id,int idProjects)
        {
            Task task = dbTask.Tasks.FirstOrDefault(u=>u.id==id && u.idProject==idProjects);
            return task;
        }
        public Project DetailsProject(int id)
        {
            Project project = dbProject.Projects.Find(id);
            return project;
        }
        public Task Create(Task task)
        {
            dbTask.Tasks.Add(task);
            dbTask.SaveChanges();
            return task;
        }
        public Project Create(Project project) 
        {
            dbProject.Projects.Add(project);
            dbProject.SaveChanges();
            return project;
        }
        public void DeleteTask(int id) 
        {
            Task task = dbTask.Tasks.Find(id);
            dbTask.Tasks.Remove(task);
            dbTask.SaveChanges();
        }
        public void DeleteProject(int id)
        {
            Project project = dbProject.Projects.Find(id);
            dbProject.Projects.Remove(project);
            dbProject.SaveChanges();
        }
        public Task Edit(Task task)
        {
            Task item = dbTask.Tasks.Find(task.id);
            item.name = task.name;
            item.description = task.description;
            item.priroty = task.priroty;
            item.status = task.status;
            item.idProject = task.idProject;
            dbTask.SaveChanges();
            return item;
        }
        public Project Edit(Project project) 
        {
            Project item = dbProject.Projects.Find(project.id);
            item.name = project.name;
            item.startProject = project.startProject;
            item.completionProject = project.completionProject;
            item.statusProject = project.statusProject;
            dbProject.SaveChanges();
            return item;
        }
    }
}