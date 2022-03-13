using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class BLLUser<User> : ICRUD<User> where User : class
    {
        UserSettings<User> settings = new UserSettings<User>();
        public void Add(User t)
        {
            settings.Add(t);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            return settings.List();
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
