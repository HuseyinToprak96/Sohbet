using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Models;
using System.Data.Entity;
namespace DAL
{
    public class init:DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.Add(new User { UserName = "crayzBoy", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil1.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil2.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil3.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil4.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil5.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil6.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy1", Password = "123", FirstName = "Cevdet", LastName = "Sunar", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil7.jpg" });
            context.Users.Add(new User { UserName = "crayzBoy2", Password = "12", FirstName = "Selami", LastName = "Şahin", Mail = "cevo_bela@hotmail.com", PhoneNumber = "05365548", status = true, Approval = true, Photo = "/image/profil8.jpg" });

        }
    }
}
