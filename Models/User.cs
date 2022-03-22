using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
  
   public class User
    {
        public int UserID { get; set; }
        public string Photo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public bool Approval { get; set; }
        public bool status { get; set; }
        //NAV( Önüne virtual yazmak LazyLoading)
        public virtual List<Message> messages { get; set; }
    }
}
