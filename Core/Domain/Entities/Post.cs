﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }//başlık
        public string Content { get; set; }//içerik 
        public int UserId { get; set; }//yazan kullanıcı
        public ICollection<Comment> Comments { get; set; }
        public int CommentId{ get; set; }
        public DateTime releasedate { get; set; }//yazım tarihi

    }
}
