using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public interface ICRUD<T>
    {
       void Add(T t);
        List<T> List();
        void Delete(int id);
        void Update(T t);
        List<T> Find(int id);
    }
}
