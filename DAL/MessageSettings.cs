using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class MessageSettings<Message>:Icrud<Message>
    {
        Context db = new Context();

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Message Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
        //  public void SendMessage(Message message)
        //  {
        //      Models.Message mes = (message as Models.Message) as Models.Message;
        //      db.Messages.Add(mes);
        //  }

        //public List<Message> Messages()
        //  {
        //      List<Message> messagesList = db.Messages.ToList() as List<Message>;
        //      return messagesList;
        //  }
        //  public void DeleteMessage(int id)
        //  {
        //      db.Messages.Remove(db.Messages.Where(m => m.MessageID == id).SingleOrDefault());
        //      db.SaveChanges();
        //  }
    }
}
