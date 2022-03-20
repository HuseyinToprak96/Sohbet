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
            // var messages = bLLMessages.List().Where(u => u.SenderID == userID && u.RecipientID == id || u.RecipientID == userID && u.SenderID == id).ToList();
            var messages = context.Messages.ToList();
            messages.Add(new Message { MessageContent = "Selam", Seen=false, SenderID=2, RecipientID=1, Date=DateTime.Now });
            messages.Add(new Message { MessageContent = "Selam", Seen = false, SenderID = 1, RecipientID = 2, Date = DateTime.Now });
            return Json(messages.OrderByDescending(m=>m.MessageID),JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SendMessage(string mesaj)
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeletePersonMessages(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteMessage()
        {
            return View();
        }

    }
}