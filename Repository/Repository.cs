using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace RepositoryLayer
{
  public class Repository<T> :Icrud<T> 
    {
        Icrud<T> repository;
        public Repository(Icrud<T> DB)
        {
            repository = DB;
        }

        public void Add(T t)
        {
            repository.Add(t);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public T Find(int id)
        {
            return repository.Find(id);
        }

        public List<T> List()
        {
            return repository.List();
        }
        public void Update(T t)
        {
            repository.Update(t);
        }
    }
}
