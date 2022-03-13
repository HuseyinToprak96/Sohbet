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
    public class PageController : Controller
    {
        BLLUser<User> setting = new BLLUser<User>();
        // GET: Page
        public ActionResult Home()
        {
            Users();
            return View();
        }
        public void Users()
        {
            int id = Convert.ToInt32(Session["ID"]);
            TempData["Users"] = setting.List().Where(u => u.UserID != id).ToList();
        }
        public ActionResult SignUpPage()
        {
            return PartialView();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(VMLogin login)
        {
            var user = setting.List().Where(u => u.UserName == login.UserName && u.Password == login.Password).SingleOrDefault();
            if (user != null)
            {
                Session["ID"] = user.UserID;
                Session["Status"] = user.status;
            }
            else
            {
                ViewBag.Hata = "Hatalı bilgi girişi. Tekrar Dene.";
            }
            return RedirectToAction("Home");
        }
    }
}