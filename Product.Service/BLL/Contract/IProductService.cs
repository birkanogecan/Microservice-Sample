using Product.Core.Query.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.BLL.Contract
{
    public interface IProductService
    {
        List<GetAllProductQueryResponse> GetAllProduct();

        GetAllProductQueryResponse GetProductById(int Id);
    }
}
