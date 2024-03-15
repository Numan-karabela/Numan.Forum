using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.GetPost
{
    public class GettPostQueryRequest:IRequest<GettPostQueryResponse>
    {
        public int id { get; set; }
    }
}
