using MediatR;
using Product.Core.Query.Response;
using Product.Service.BLL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.BLL.Impl
{
    public class ProductService : IProductService
    {
        //TODO: ProductDomain için aggregateroot'a dönüştürülebilir
        public List<GetAllProductQueryResponse> GetAllProduct()
        {
            var item = new GetAllProductQueryResponse
            {
                Id = 1,
                Name = "test product",
                Price = (decimal)16.99,
                Quantity = 4,
                CreateTime = DateTime.Now
            };

            var list = new List<GetAllProductQueryResponse>();
            list.Add(item);

            return list;
        }

        public GetAllProductQueryResponse GetProductById(int Id)
        {
            var item = new GetAllProductQueryResponse
            {
                Id = Id,
                Name = "test product",
                Price = (decimal)16.99,
                Quantity = 4,
                CreateTime = DateTime.Now
            };

            return item;
        }
    }
}
