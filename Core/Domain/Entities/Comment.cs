﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }//içerik
        public int UserId { get; set; }//yazan kullanıcı
        public int PostId { get; set; }
    }
}
