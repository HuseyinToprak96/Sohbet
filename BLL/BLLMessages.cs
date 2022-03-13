using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{
   public class BLLMessages<T> : ICRUD<T> where T : class
    {
        MessageSettings<T> settings = new MessageSettings<T>();
        public void Add(T t)
        {
          
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
