using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class MessageSettings<Messages>//:IRepositoryMessages<Messages>
    {
        Context db = new Context();

        public void Add(Message t)
        {
            Models.Message message = t as Models.Message;
            db.Messages.Add(message);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Messages.Remove(db.Messages.Where(m => m.MessageID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public List<Message> Find(int id)
        {
            var messages = db.Messages.Where(m => m.RecipientID == id || m.SenderID == id).ToList();
            List<Message> List = messages as List<Message>;
            return List;
        }

        public List<Message> List()
        {
            List<Message> List=db.Messages.ToList() as List<Message>;
            return List; 
        }

        public void Update(Message t)
        {
           Models.Message message = t as Models.Message;
            var mes = db.Messages.Where(m => m.MessageID == message.MessageID).SingleOrDefault();
        }
    }
}
