using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
   public interface IRepositoryMessages<Message>
    {
        void SendMessage(Message message);
        void DeleteMessage(int id);
        List<Message> Messages();
    }
}
