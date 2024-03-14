using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.DeletePost
{
    public class DeletePostCommandRequest:IRequest<DeletePostCommandResponse>
    {
        public int id { get; set; }
    }
}
