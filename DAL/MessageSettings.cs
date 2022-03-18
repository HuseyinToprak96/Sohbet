using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class MessageSettings<Message>:IRepositoryMessages<Message>
    {
        Context db = new Context();
        public void SendMessage(Message message)
        {
            Models.Message mes = (message as Models.Message) as Models.Message;
            db.Messages.Add(mes);
        }

      public List<Message> Messages()
        {
            List<Message> messagesList = db.Messages.ToList() as List<Message>;
            return messagesList;
        }
        public void DeleteMessage(int id)
        {
            db.Messages.Remove(db.Messages.Where(m => m.MessageID == id).SingleOrDefault());
            db.SaveChanges();
        }
    }
}
