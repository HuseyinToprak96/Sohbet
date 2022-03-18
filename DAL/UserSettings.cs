using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
   public class UserSettings:IRepositoryUsers<User>
    {
        Context db = new Context();
        public void DeleteUser(int id)
        {
            db.Users.Remove(db.Users.Where(u => u.UserID == id).SingleOrDefault());
            db.SaveChanges();
        }
        public User FindUser(int id)
        {
            var user = db.Users.Where(u => u.UserID == id).SingleOrDefault();
            User us = (user as User) as User;
            return us;
        }
        public void SignUp(User user)
        {
            Models.User us = (user as Models.User) as Models.User;
            db.Users.Add(us);
            db.SaveChanges();
        }

        public void UpdateUser(User use)
        {
            Models.User user = use as Models.User;
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

        public List<User> Users()
        {
            List<User> List = db.Users.ToList() as List<User>;
            return List;
        }
    }
}
