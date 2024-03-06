using Domain.Entities.Common;
using Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment:BaseEntity//yorum
    {
        public string Content { get; set; }//içerik 
        public int PostId { get; set; }
        public Post Post { get; set; }
        public AppUser User{ get; set; }
        public int UserId{ get; set; }

    }
}
