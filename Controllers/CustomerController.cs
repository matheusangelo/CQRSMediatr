using Mediatr.Commands;
using Mediatr.Handlers;
using Mediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mediatr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get([FromServices] IMediator mediator,
                                 [FromQuery] FindCustomerByName command)
        {
            return Ok(mediator.Send(command).Result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create(
                                [FromServices] IMediator mediator,
                                [FromBody] CreateCustomerCommand command)
        {
            return Ok(mediator.Send(command).Result);
        }
    }
}
