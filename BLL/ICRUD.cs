using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public interface ICRUD<T> where T:class
    {
        void Add(T t);
        void Delete(int id);
        List<T> List();
        void Update(T t);
        
    }
}
