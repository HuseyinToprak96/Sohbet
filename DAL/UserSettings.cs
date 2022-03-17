using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserSettings<User> //:IRepo
    {
        Context db = new Context();
        
        public void Add(User t)
        {
            Models.User user = new Models.User();
            db.Users.Add(user);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            db.Users.Remove(db.Users.Where(u => u.UserID == id).SingleOrDefault());
            db.SaveChanges();
        }
        public List<User> Find(int id)
        {
            List<User> User = db.Users.Where(u => u.UserID == id).ToList() as List<User>;
            return User;
        }

        public List<User> List()
        {
            List<User> List=db.Users.ToList() as List<User>;
            return List;
        }

        public void Update(User t)
        {
            Models.User user = t as Models.User;
            var result = db.Users.Where(u => u.UserID == user.UserID).SingleOrDefault();
            result.UserName = user.UserName;
            result.FirstName = user.FirstName;
            result.LastName = user.LastName;
            result.Password = user.Password;
            result.Photo = user.Photo;
            result.status = user.status;
            result.PhoneNumber = user.PhoneNumber;
            result.Approval = user.Approval;
            db.SaveChanges();
        }

    }
}
