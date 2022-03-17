using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
  public class Repository<T> :IRepository<T>
    {
        IRepository<T> repository;
        public Repository(IRepository<T> DB)
        {
            repository = DB;
        }
        public void DeleteMessage(int id)
        {
            repository.DeleteMessage(id);
        }

        public void DeleteUser(int id)
        {
            repository.DeleteUser(id);
        }

        public User FindUser(int id)
        {
            return repository.FindUser(id);
        }

        public List<Message> Messages()
        {
          return  repository.Messages();
        }

        public void SendMessage(Message message)
        {
            repository.SendMessage(message);
        }

        public void SignUp(User user)
        {
            repository.SignUp(user);
        }

        public void UpdateUser(User user)
        {
            repository.UpdateUser(user);
        }

        public List<User> Users()
        {
            return repository.Users();
        }
    }
}
