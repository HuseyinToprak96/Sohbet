using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
   public interface IRepositoryUsers<User>
    {
        void SignUp(User user);
        List<User> Users();
        void DeleteUser(int id);
        void UpdateUser(User user);
        User FindUser(int id);
    }
}
