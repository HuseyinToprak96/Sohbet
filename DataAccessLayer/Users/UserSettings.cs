using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer.Interface;
namespace DataAccessLayer.Users
{
    class UserSettings<T>:ICRUD<T> where T:class
    {
        Context db = new Context();

        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            return db.Users.ToList();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
