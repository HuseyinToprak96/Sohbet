using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface Icrud<T>
    {
        void Add(T t);
        List<T> List();
        void Delete(int id);
        void Update(T t);
        T Find(int id);
    }
}
