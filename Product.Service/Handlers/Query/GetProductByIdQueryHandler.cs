using MediatR;
using Product.Core.Query.Request;
using Product.Core.Query.Response;
using Product.Service.BLL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.Handlers.Query
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
