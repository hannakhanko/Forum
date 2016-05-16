using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using Forum.Services;
using Forum.Models;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new UserContext())
            {
                bool d = db.Database.Exists();
                var users = db.Users;
                foreach (User u in users)
                {
                    string r = u.Name;
                }
            }
            return View();
        }
    }
}