﻿using MediatR;
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
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private IProductService _productService;
        public GetAllProductQueryHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return _productService.GetAllProduct();
        }
    }
}
