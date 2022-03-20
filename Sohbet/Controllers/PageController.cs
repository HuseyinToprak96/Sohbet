using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sohbet.VMmodels;
using BLL;
using Models;
using ModelsView;
using DAL;
namespace Sohbet.Controllers
{
    public class PageController : Controller
    {
        BLLUser<User> setting = new BLLUser<User>();
        BLLMessages<Message> messages = new BLLMessages<Message>();
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
            Users();
            return View();
        }
        public ActionResult Contact()
        {
            Users();
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
                Session.Timeout=2;
            }
            else
            {
                ViewBag.Hata = "Hatalı bilgi girişi. Tekrar Dene.";
            }
            return RedirectToAction("Home");
        }
        public ActionResult LoginOK()
        {
            Context context = new Context();
            VMLoginOK oK = new VMLoginOK();
            int id=Convert.ToInt32(Session["ID"]);
            oK.user = setting.List().Where(u => u.UserID == id).SingleOrDefault();
            oK.Messages = context.Messages.Where(m=>m.RecipientID==id && m.Seen==false).ToList();
            return PartialView(oK);
        }
      
        public ActionResult Out()
        {
            Session.Abandon();
            return RedirectToAction("Home");
        }
        public ActionResult PageSendMessage()
        {
            return PartialView();
        }
    }
}