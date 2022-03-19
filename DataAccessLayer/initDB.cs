using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;
namespace DataAccessLayer
{
    class initDB:DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.Add(new User { UserName = "crayzBoy", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy2", Password = "12", FirstName = "Selami", LastName = "Şahin", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/img/admin.jpg" });

        }
    }
}
