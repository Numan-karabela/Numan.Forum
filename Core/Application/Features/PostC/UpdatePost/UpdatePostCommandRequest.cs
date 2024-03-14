using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.UpdatePost
{
    public class UpdatePostCommandRequest:IRequest<UpdatePostCommandResponse>
    {
        public string Title { get; set; }//başlık
        public string Content { get; set; }//içerik 

    }
}
