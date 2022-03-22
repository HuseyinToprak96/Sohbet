using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using DAL;
namespace Sohbet.Controllers
{
    public class MessageController : Controller
    {
        BLLMessages<Message> bLLMessages = new BLLMessages<Message>();
       BLLUser<User> bLLUser = new BLLUser<User>();
        MessageSettings<Message> Messages = new MessageSettings<Message>();
        Context context = new Context();
        // GET: Message
        public ActionResult Index()
        {
            int id = Convert.ToInt32(Session["ID"]);
            TempData["Users"] = bLLUser.List().Where(u=>u.UserID!=id).ToList();
            return View();
        }
        //AJAX
        public JsonResult MessagesPerson(int? id)
        {
            int userID = Convert.ToInt32(Session["UserID"]);
            var messages = bLLMessages.List();
            return Json(messages.OrderByDescending(m => m.MessageID), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SendMessage(Message message)
        {
            int id = Convert.ToInt32(Session["ID"]);
            message.SenderID = id;
            message.Seen = false;
            message.Date = DateTime.Now;
            bLLMessages.Add(message);
            return RedirectToAction("../Page/Home");
        }
        public ActionResult Clear(int id)
        {
            int userID = Convert.ToInt32(Session["ID"]);
            var list = context.Messages.Where(m => m.SenderID == id && m.RecipientID == userID || m.SenderID == userID && m.RecipientID == id).ToList();
            foreach (var item in list)
            context.Messages.Remove(item);
            context.SaveChanges();
            return RedirectToAction("../Page/Home");
        }
        [HttpPost]
        public ActionResult DeleteMessage()
        {
            return View();
        }

    }
}