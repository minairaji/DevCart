using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Devcard_MVC.Controllers
{
    public class TestController1 : Controller
    {
        //public FileResult Index()
        //{
        //    ///return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "salamtest.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}
        //public JsonResult Index()
        //{
        //    return Json( new
        //    {
        //        id=1,
        //        name="ali",
        //        job="programmer",
        //        site="yamour.com"
        //    });
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("http:\\www.sanjesh.org");
        //}
        public IActionResult Index()
        {
            return new OkResult();
            //return new BadRequestResult();
            //return new NotFoundResult();
        }
    }
}
