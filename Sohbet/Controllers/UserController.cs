using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sohbet.VMmodels;
using BLL;
using Models;
namespace Sohbet.Controllers
{
    public class UserController : Controller
    {
        BLLUser<User> setting = new BLLUser<User>();
        // GET: User
        public ActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult SingUp(User user)
        {
            setting.Add(user);
            return RedirectToAction("/Page/Home");
        }
        public ActionResult Forgot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forgot(int id)
        {
            return View();
        }
        public ActionResult MyProfile(int id)
        {
            return View();
        }
        public ActionResult Settings(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Settings(string id)
        {
            return View();
        }
    }
}