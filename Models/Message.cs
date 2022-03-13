using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public DateTime Date { get; set; }
        public bool Seen { get; set; }
        public virtual User Sender { get; set; }
        public virtual User Recipient { get; set; }
    }
}
