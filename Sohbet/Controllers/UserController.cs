using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sohbet.VMmodels;
using BLL;
using Models;
using DAL;
namespace Sohbet.Controllers
{
    public class UserController : Controller
    {
        BLLUser<User> Datas = new BLLUser<User>();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingUp(User user)
        {
            Datas.Add(user);
            return RedirectToAction("/Page/Home");
        }
        public ActionResult Forgot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forgot(string eposta)
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            int id = Convert.ToInt32(Session["ID"]);
            return View(Datas.Find(id));
        }
        public ActionResult Settings()
        {
            int id = Convert.ToInt32(Session["ID"]);
            return View(Datas.Find(id));
        }
        [HttpPost]
        public ActionResult Settings(User user)
        {
            Datas.Update(user);
            Session.Abandon();
            return View();
        }
    }
}