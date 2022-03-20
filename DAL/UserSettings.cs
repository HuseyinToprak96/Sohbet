using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
   public class UserSettings<User>:Icrud<User>
    {
        Context db = new Context();

        public void Add(User user)
        {
               Models.User us = (user as Models.User) as Models.User;
               db.Users.Add(us);
               db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Users.Remove(db.Users.Where(u => u.UserID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        //public User Find(int id)
        //{
        //    Models.User user = db.Users.Where(u => u.UserID == id).SingleOrDefault();
        //    User us =(user as User) as User;
        //    return us;
        //}

        public List<User> List()
        {
            List<User> List = db.Users.ToList() as List<User>;
              return List;
        }

        public void Update(User user)
        {
            Models.User use = user as Models.User;
            var result = db.Users.Where(u => u.UserID == use.UserID).SingleOrDefault();
            result.UserName = use.UserName;
            result.FirstName = use.FirstName;
            result.LastName = use.LastName;
            result.Password = use.Password;
            result.Photo = use.Photo;
            result.status = use.status;
            result.PhoneNumber = use.PhoneNumber;
            result.Approval = use.Approval;
           db.SaveChanges();
        }

    }
}
