using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using RepositoryLayer;
namespace BLL
{
   public class BLLMessages<Message> 
    {
        MessageSettings<Message> messageSettings = new MessageSettings<Message>();
        public void Add(Message message)
        {
            IRepository<Message> msj = (messageSettings as IRepository<Message>) as IRepository<Message>;
            Models.Message m = (message as Models.Message) as Models.Message;
            Repository<Message> repository = new Repository<Message>(msj);
            repository.SendMessage(m);
                }

        public void Delete(int id)
        {
            IRepository<Message> msj = (messageSettings as IRepository<Message>) as IRepository<Message>;
            Repository<Message> repository = new Repository<Message>(msj);
            repository.DeleteMessage(id);
        }

        public List<Models.Message> List()
        {
            IRepository<Message> msj = (messageSettings as IRepository<Message>) as IRepository<Message>;
            Repository<Message> repository = new Repository<Message>(msj);
            return repository.Messages();
        }
    }
}
