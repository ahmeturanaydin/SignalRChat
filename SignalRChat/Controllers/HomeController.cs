using DocumentFormat.OpenXml.Wordprocessing;
using SignalRChat.Models;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        chatHubEntities1 db = new chatHubEntities1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            Users user = new Users();
            user.username = form["username"].Trim();
            user.password = form["password"].Trim();
            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }
        public ActionResult Chat()
        {
            return View();
        }
    }
}  
