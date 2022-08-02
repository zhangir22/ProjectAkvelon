using DashboardAkvelonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DashboardAkvelonProject.Abstract
{
    interface IRepos
    {
        List<Project> GetAllProject();// Получение Списка Проектов
        void GetTasksByElementId(List<Task> tasks, int id);//Для получение Задачи по его индификатору
        List<Task> Tasks(int id);// Получение Задач который отностся к Проекту
        Task DetailsTask(int id, int idProjects);//Для Получение Деталей определенной Задачи
        Project DetailsProject(int id);// Получение Деталей определенного Проекта
        Task Create(Task task);// Создание Задачи
        Project Create(Project project);// Создание Проекта
        void DeleteTask(int id);// Удаление Задачи
        void DeleteProject(int id);// Удаление Проекта
        Task EditTask(Task task);// Редактирование Задачи
        Project EditProject(Project project);// Редакатирование Проекта
    }
}
