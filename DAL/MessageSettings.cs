using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class MessageSettings<Message>:Icrud<Message>
    {
        Context db;
        public MessageSettings()
        {
        db = new Context();
        }
        public void Add(Message message)
        {
            Models.Message mes = (message as Models.Message) as Models.Message;
            db.Messages.Add(mes);
        }

        public void Delete(int id)
        {
            db.Messages.Remove(db.Messages.Where(m => m.MessageID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public Message Find(int id)
        {
            throw new NotImplementedException();
        }

        //public Message Find(int id)
        // {
        //    var mes = db.Messages.ToList().Where(m=>m.MessageID==id).SingleOrDefault();
        //     Message message = mes as Message;
        //     return message;
        // }

        public List<Message> List()
        {
            List<Message> messagesList = db.Messages.ToList() as List<Message>;
            return messagesList;
        }

        public void Update(Message message)
        {
            Models.Message sms = message as Models.Message;
            var mes = db.Messages.Where(m => m.MessageID == sms.MessageID).SingleOrDefault();
            mes.MessageContent = sms.MessageContent;
            mes.Date = sms.Date;
            db.SaveChanges();
        }
    
    }
}
