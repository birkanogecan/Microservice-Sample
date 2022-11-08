using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Core.Command.Request;
using Order.Core.Command.Response;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommandRequest requestModel)
        {
            CreateOrderCommandResponse result = await _mediator.Send(requestModel);
            return Ok(result);
        }
    }
}