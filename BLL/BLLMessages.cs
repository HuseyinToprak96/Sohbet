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
        Repository<Message> repository;
        public BLLMessages()
        {
         repository = new Repository<Message>(messageSettings);
        }
        public void Add(Message message)
        {
            repository.Add(message);
        }
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Message> List()
        {
            return repository.List();
        }
        public Message Find(int id)
        {
            return repository.Find(id);
        }
        public void Update(Message message)
        {
            repository.Update(message);
        }
    }
}
