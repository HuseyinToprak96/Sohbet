using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.SetInitializer(new initDB());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
