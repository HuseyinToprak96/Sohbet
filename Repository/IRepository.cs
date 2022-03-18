using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace RepositoryLayer
{
   public interface IRepository<T>:IRepositoryMessages<Message>,IRepositoryUsers<User>
    {
    }
}
