using DasboardAkvelon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DasboardAkvelon.Abstract
{
    public interface IRepos
    {
        List<Project> GetAllProject();
        void GetTasksByElementId(List<Task> tasks, int id);
        List<Task> Tasks(int id);
        Task DetailsTask(int id,int idProjects);
        Project DetailsProject(int id);
        Task Create(Task task);
        Project Create(Project project);
        void DeleteTask(int id);
        void DeleteProject(int id);
        Task Edit(Task task);
        Project Edit(Project project);

    }
}
