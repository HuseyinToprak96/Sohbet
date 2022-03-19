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
           Repository<Message> repository = new Repository<Message>(messageSettings);
            repository.Add(message);
        }
        public void Delete(int id)
        {
            Repository<Message> repository = new Repository<Message>(messageSettings);
            repository.Delete(id);
        }

        public List<Message> List()
        {
            Repository<Message> repository = new Repository<Message>(messageSettings);
            return repository.List() ;
        }
    }
}
