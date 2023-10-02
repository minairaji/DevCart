using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devcard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                ///read from viewcomponent
                new Project(1,"تاکسی","پروژه انلاین تاکسی","project-1.jpg","iraji"),
                new Project(2,"ارایشگاه","پروژه انلاین ارایشگاه","project-4.jpg","پریا"),
                new Project(3,"ازمون ","پروژه انلاین ازمون فنی حرفه ای","project-figure-1.jpg","سازمان"),
                new Project(4,"فروشگاه","پروژه انلاین فروشگاه","project-5.jpg","iraji")
            };
            return View("_Projects",projects);
        }
        /*public IViewComponentResult Invoke()
        {
            return View("_Projects");
        }*/
    }
}
