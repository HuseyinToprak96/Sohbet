using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace ModelsView
{
    public class VMLoginOK
    {
        public User user { get; set; }
        public List<Message> Messages { get; set; }
    }
}
