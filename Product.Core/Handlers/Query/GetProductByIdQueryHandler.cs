using MediatR;
using Product.Application.Query.Request;
using Product.Application.Query.Response;
using Product.Service.BLL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Handlers.Query
{
    internal class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetAllProductQueryResponse>
    {
        private IProductService _productService;
        public GetProductByIdQueryHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<GetAllProductQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            return _productService.GetProductById(request.Id);
        }
    }
}
