using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;
using DAL;
namespace BLL
{
   public class BLLUser<User>
    {
        UserSettings<User> userSettings = new UserSettings<User>();
        Repository<User> repository;
        public BLLUser()
        {
            repository = new Repository<User>(userSettings);
        }
        public void Add(User user)
        {
           repository.Add(user);
        }

        public void Delete(int id)
        {
           repository.Delete(id);
        }

        public List<User> List()
       {
            return repository.List();
       }
        public void Update(User user)
        {
           repository.Update(user);
        }
        public User Find(int id)
        {
           return repository.Find(id);
        }
    }
}
