using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController: Controller
    {
        // index
        public ActionResult Index()
        {
            return View();

        }

    }
}