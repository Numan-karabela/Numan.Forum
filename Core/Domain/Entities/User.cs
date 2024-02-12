using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string EPosta { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }


    }
}
