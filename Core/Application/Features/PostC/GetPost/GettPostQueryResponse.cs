using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.GetPost
{
    public class GettPostQueryResponse
    {

        public string Title { get; set; }//başlık
        public string Content { get; set; }//içerik 
        public int UserId { get; set; }//yazan kullanıcı 

    }
}
