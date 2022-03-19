using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    interface ICRUD<T>
    {
        void Add(T t);
        void Delete(int id);
        void Update(T t);
        List<T> List();
        T Find(int id);

    }
}
