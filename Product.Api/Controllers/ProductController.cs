using DotNetCore.CAP;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Core.Events;
using Product.Core.Query.Request;
using Product.Core.Query.Response;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {

        IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = "GetAllProducts")]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductQueryRequest requestModel)
        {
            List<GetAllProductQueryResponse> allProducts = await _mediator.Send(requestModel);
            return Ok(allProducts);
        }

        [HttpGet(Name = "GetProductById")]
        public async Task<IActionResult> GetProductById([FromQuery] GetProductByIdQueryRequest requestModel)
        {
            GetAllProductQueryResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }

        [NonAction]
        [CapSubscribe(nameof(OrderCreatedEvent))]
        public void OrderCreatedEventHandler(OrderCreatedEvent @event)
        {
            Console.WriteLine("message time is:");
        }
    }
}