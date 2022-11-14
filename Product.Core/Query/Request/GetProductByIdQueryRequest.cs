using MediatR;
using Product.Application.Query.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Query.Request
{
    public class GetProductByIdQueryRequest : IRequest<GetAllProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
