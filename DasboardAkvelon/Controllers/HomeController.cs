using DasboardAkvelon.Abstract;
using DasboardAkvelon.Models;
using DasboardAkvelon.Models.Context;
using DasboardAkvelon.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DasboardAkvelon.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryContext repositoryContext = new RepositoryContext();
        private IRepos repos = new ProjectRepos();


        public ActionResult Index(string value) 
        {
            var lst = repos.GetAllProject();
            if (value == "name")
            {
                var nameSort = from n in lst
                               orderby n.name
                               select n;
                return View(nameSort.ToList());
            }

            if (value == "start")
            {
                var startSort = from s in lst
                                orderby s.startProject
                                select s;
                return View(startSort.ToList());
            }
            if (value == "completion")
            {
                var completionSort = from c in lst
                                     orderby c.completionProject
                                     select c;
                return View(completionSort.ToList());
            }
            if (value == "status")
            {
                var statusSort = from s in lst
                                 orderby s.statusProject
                                 select s;
                return View(statusSort.ToList());
            }
            if (value == "priroty")
            {
                var prirotySort = from p in lst
                                  orderby p.priroty
                                  select p;
                return View(prirotySort.ToList());
            }
            return View(lst);
        }
    
        public ActionResult Tasks(int id,string value)
        {
            var lst = repos.Tasks(id);
            if (value == "name")
            {
                var nameSort = from n in lst
                               orderby n.name
                               select n;
                return View(nameSort.ToList());
            }

            if (value == "description")
            {
                var startSort = from s in lst
                                orderby s.description
                                select s;
                return View(startSort.ToList());
            }
            if (value == "status")
            {
                var statusSort = from s in lst
                                 orderby s.status
                                 select s;
                return View(statusSort.ToList());
            }
            if (value == "priroty")
            {
                var prirotySort = from p in lst
                                  orderby p.priroty
                                  select p;
                return View(prirotySort.ToList());
            }
            return View(lst);
        }

        public ActionResult DetailsTask(int id,int idProject)
        {
            return View(repos.DetailsTask(id, idProject));
        }
        public ActionResult DetailsProject(int id)
        {
            return View(repos.DetailsProject(id));
        }
        [HttpGet]
        public ActionResult CreateTask(int idProject)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTask([Bind(Include = "name,status,description,priroty")] Task task, int idProject) 
        {
            Task item = null;
            if (ModelState.IsValid)
            {
                if (task != null)
                {
                    task.idProject = idProject;
                    item = repos.Create(task);
                    return RedirectToAction("Index");
                }
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProject([Bind(Include ="name,startProject,completionProject,statusProject,priroty")] Project project)
        {
            Project item = null;
            if (ModelState.IsValid)
            {
                if (project != null)
                {
                    item = repos.Create(project);
                    return RedirectToAction("Index");
                }
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult EditTask(int id,int idProject)
        {
            return View(repos.DetailsTask(id, idProject));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditTask(Task task)
        {
            Task item = null;
            if (ModelState.IsValid)
            {
                if (task != null)
                {
                    item = repos.Edit(task);
                    return RedirectToAction("Index");
                }
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult EditProject(int id)
        {
            return View(repos.DetailsProject(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProject(Project project)
        {
            Project item = null;
            if (ModelState.IsValid)
            {
                if (project != null)
                {
                    item = repos.Edit(project);
                    return RedirectToAction("Index");
                }
            }
            return View(item);
        }
        [HttpGet]
        public ActionResult DeleteTask(int id,int idProject)
        {
            return View(repos.DetailsTask(id, idProject));
        }
        [HttpPost, ActionName("DeleteTask")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteTaskConfirmed(int id)
        {
            repos.DeleteTask(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteProject(int id)
        {
            return View(repos.DetailsProject(id));
        }
        [HttpPost, ActionName("DeleteProject")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProjectConfirmed(int id)
        {
            repos.DeleteProject(id);
            return RedirectToAction("Index");
        }


        //private List<Task> GetTasksByElementId(int? id) 
        //{
        //    List<Task> projectTask = new List<Task>();
        //    foreach (var item in repositoryContext.dbTask.Tasks)
        //    {
        //        if (item.idProject == id)
        //        {
        //            projectTask.Add(item);
        //        }
        //    }
        //    return projectTask;
        //}

        //public ActionResult Board() 
        //{
        //    return View(repositoryContext.dbProject);
        //}

        //public ActionResult ProjectTask(int? id) 
        //{
        //    if (ModelState.IsValid) 
        //    {
        //        if (id != null)
        //        {
        //            var projectTask = GetTasksByElementId(id);
        //            if (projectTask != null)
        //            {
        //                return View(projectTask);
        //            }
        //        }
        //    }

        //}
        //[HttpGet]
        //public ActionResult CreateTask()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult CreateTask(Task model) 
        //{
        //    if (model != null)
        //    {
        //        model.idProject = idProjectNow;
        //        repositoryContext.dbTask.Tasks.Add(model);
        //        repositoryContext.dbTask.SaveChanges();
        //    }
        //    return RedirectToAction("Board");
        //}


        //[HttpGet]
        //public ActionResult CreateProject() 
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult CreateProject()
        //{
        //    if (name!=null) 
        //    {
        //        if (startProject != null)
        //        {
        //            if(completionProject != null)
        //            {
        //                if (status != null)
        //                {
        //                    if(priroty != 0)
        //                    {
        //                            repositoryContext.dbProject.Projects.Add(new Project
        //                            {
        //                                name = name,
        //                                startProject = Convert.ToDateTime(startProject),
        //                                completionProject = Convert.ToDateTime(completionProject),
        //                                statusProject = status,
        //                                priroty = priroty
        //                            });
        //                    repositoryContext.dbProject.SaveChanges();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return View();
        //}

        //public ActionResult EditProject(int?id)
        //{
        //    if (ModelState.IsValid) 
        //    {
        //        if (id != null)
        //        {

        //        }
        //    }
        //}

        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}
