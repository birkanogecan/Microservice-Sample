using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace Checkout.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        public CheckoutController()
        {
            
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public void Get()
        {
           
        }
       
    }
}