using MediatR;
using Product.Core.Query.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Query.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {

    }
}
