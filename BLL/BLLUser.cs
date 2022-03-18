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
        UserSettings userSettings = new UserSettings();
        public void Add(User user)
        {
            IRepository<User> us = (userSettings as IRepository<User>) as IRepository<User>;
           Models.User u = (user as Models.User) as Models.User;
            Repository<User> repository = new Repository<User>(us);
            repository.SignUp(u);
        }

        public void Delete(int id)
        {
            IRepository<User> us = (userSettings as IRepository<User>) as IRepository<User>;
            Repository<User> repository = new Repository<User>(us);
            repository.DeleteUser(id);
        }

        public List<Models.User> List()
       {
            IRepository<User> us = (userSettings as IRepository<User>) as IRepository<User>;
            Repository<User> repository = new Repository<User>(us);
            return repository.Users();
      }

        public void Update(Models.User user)
        {
            IRepository<User> us = (userSettings as IRepository<User>) as IRepository<User>;
            Repository<User> repository = new Repository<User>(us);
            repository.UpdateUser(user);
        }
    }
}
